using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WoH_CardEdit_NetFramework
{
    public class DataAccess
    {
        // Singleton Instance
        public static DataAccess Instance = new DataAccess();

        // Properties
        public string[] RewardTypeNames { get; protected set; }
        public RewardType[] RewardTypes { get; protected set; }
        public string[] Locations { get; protected set; }
        public string[] CheckTypes { get; protected set; }

        // Constructors
        protected DataAccess()
        {
            LoadDataFiles();
        }

        // Methods
        public EventCard LoadITOFile(string itoPath)
        {
            return EventCardSerializer.FromITO(File.ReadAllText(itoPath));
        }

        public void SaveITOFile(string itoPath, EventCard card)
        {
            File.WriteAllText(itoPath, EventCardSerializer.ToITO(card));
        }

        protected void LoadDataFiles()
        {
            this.Locations = ReadLinesIfExists(GetDataFilePath("location.txt")) ?? new string[] { "global" };
            this.CheckTypes = ReadLinesIfExists(GetDataFilePath("check_types.txt")) ?? new string[] { "global" };
            this.RewardTypeNames = LoadRewardTypeList();
            this.RewardTypes = this.RewardTypeNames.Select(LoadRewardsType).ToArray();
        }

        #region File System Nonsense
        protected static string GetDataRoot()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        }

        protected static string GetDataFilePath(string fileName)
        {
            return Path.Combine(GetDataRoot(), fileName);
        }

        protected static string GetRewardsFilePath(string rewardsTypeName)
        {
            return Path.Combine(GetDataRoot(), "rewards", rewardsTypeName + ".txt");
        }

        protected static string[] ReadLinesIfExists(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllLines(filePath);
            return null;
        }
        #endregion

        #region Rewards Type Loading
        protected static string[] LoadRewardTypeList()
        {
            return ReadLinesIfExists(GetDataFilePath("reward_types.txt")) ?? new string[] { "stamina", "reason", "doom", "experience", "funds" };
        }

        protected static RewardType LoadRewardsType(string rewardsTypeName)
        {
            var rv = new RewardType();
            rv.Name = rewardsTypeName;
            rv.LookupValues = ReadLinesIfExists(GetRewardsFilePath(rewardsTypeName));
            return rv;
        }

        #endregion
    }

    #region Data Objects
    public class Reward
    {
        public string RewardType { get; set; }
        public string RewardValue { get; set; }
    }

    public class RewardType
    {
        public string Name { get; set; }
        public string[] LookupValues { get; set; }
    }

    public class EventOutcome
    {
        public string Message { get; set; }
        public Reward Reward { get; set; }
    }

    public class EventOption
    {
        public string ButtonText { get; set; }
        public string CheckType { get; set; }
        public EventOutcome SuccessOutcome { get; set; }
        public EventOutcome FailureOutcome { get; set; }
    }

    public class EventCard
    {
        public string EventTitle { get; set; }
        public string About { get; set; }
        public string ImagePath { get; set; }
        public bool IsBigImage { get; set; }
        public string Author { get; set; }
        public string Contact { get; set; }
        public string EventText { get; set; }
        public string Location { get; set; }
        public EventOption[] EventOptions { get; set; }
    }
    #endregion

    #region Serializers

    // fck writing this garbage
    public static class EventCardSerializer
    {
        private static readonly string OPTION_LETTERS = "abc";
        private static readonly char[] ITO_SPLIT_ARRAY = new char[] { '=' };

        public static string ToITO(EventCard card)
        {
            // Jam out the data with some regard for human readability
            var sb = new StringBuilder();
            sb.AppendLine("[event]");

            // Event Name & Description
            sb.WriteItoProperty(ITOFieldNames.EVENT_NAME, card.EventTitle);
            sb.WriteItoProperty(ITOFieldNames.EVENT_ABOUT, card.About);
            sb.AppendLine();

            // Author & Contact Details
            sb.WriteItoProperty(ITOFieldNames.EVENT_AUTHOR, card.Author);
            sb.WriteItoProperty(ITOFieldNames.EVENT_CONTACT, card.Contact);
            sb.AppendLine();

            // Essentials
            sb.WriteItoProperty(ITOFieldNames.EVENT_FLAVOR, card.EventText);
            sb.WriteItoProperty(ITOFieldNames.EVENT_LOCATION, card.Location);
            sb.WriteItoProperty(ITOFieldNames.EVENT_OPTIONS, card.EventOptions.Length.ToString());
            sb.WriteItoProperty(ITOFieldNames.EVENT_IMAGE, card.ImagePath);
            sb.AppendLine();

            // Options Time!
            for (var i = 0; i < card.EventOptions.Length; i++)
            {
                var option = card.EventOptions[i];

                sb.WriteItoOptionProperty(ITOFieldNames.OPTION, OPTION_LETTERS[i], option.ButtonText);
                sb.WriteItoOptionProperty(ITOFieldNames.OPTION_TEST, OPTION_LETTERS[i], option.CheckType);                

                if (option.SuccessOutcome != null)
                {
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_SUCCESS, OPTION_LETTERS[i], option.SuccessOutcome.Message);
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_WINPRIZE, OPTION_LETTERS[i], option.SuccessOutcome.Reward.RewardType);
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_WINNUMBER, OPTION_LETTERS[i], option.SuccessOutcome.Reward.RewardValue);
                }

                if (option.FailureOutcome != null)
                {
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_FAILURE, OPTION_LETTERS[i], option.FailureOutcome.Message);
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_FAILPRIZE, OPTION_LETTERS[i], option.FailureOutcome.Reward.RewardType);
                    sb.WriteItoOptionProperty(ITOFieldNames.OPTION_FAILNUMBER, OPTION_LETTERS[i], option.FailureOutcome.Reward.RewardValue);
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static EventCard FromITO(string content)
        {
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var propBag = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                // throw out malformed lines
                var segments = line.Split(ITO_SPLIT_ARRAY, 2);
                if (segments.Length != 2 || !segments[1].StartsWith("\"") || !segments[1].EndsWith("\""))
                    continue;

                // should explode on dupes but lazy
                if (!propBag.ContainsKey(segments[0]))
                    propBag.Add(segments[0], null);

                // jam the pair in the prop bag for later
                propBag[segments[0]] = UnescapeItoValue(segments[1]);
            }

            // look we're gonna try to load as much as we can here, even if it's garbage
            var card = new EventCard();

            // Event Name & Description
            card.EventTitle = propBag.TryGetItoValue(ITOFieldNames.EVENT_NAME);
            card.About = propBag.TryGetItoValue(ITOFieldNames.EVENT_ABOUT);

            // Author & Contact Details
            card.Author = propBag.TryGetItoValue(ITOFieldNames.EVENT_AUTHOR);
            card.Contact = propBag.TryGetItoValue(ITOFieldNames.EVENT_CONTACT);

            // Essentials
            card.EventText = propBag.TryGetItoValue(ITOFieldNames.EVENT_FLAVOR);
            card.Location = propBag.TryGetItoValue(ITOFieldNames.EVENT_LOCATION);
            card.ImagePath = propBag.TryGetItoValue(ITOFieldNames.EVENT_IMAGE);

            // Options Time!
            var optionCountString = propBag.TryGetItoValue(ITOFieldNames.EVENT_OPTIONS);
            int optionCount;
            int.TryParse(optionCountString, out optionCount);
            var tmpList = new List<EventOption>();
            for (var i = 0; i < optionCount; i++)
            {
                var option = new EventOption();
                option.ButtonText = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION, OPTION_LETTERS[i]);
                option.CheckType = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_TEST, OPTION_LETTERS[i]);

                option.SuccessOutcome = new EventOutcome();
                option.SuccessOutcome.Reward = new Reward();
                option.SuccessOutcome.Message = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_SUCCESS, OPTION_LETTERS[i]);
                option.SuccessOutcome.Reward.RewardType = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_WINPRIZE, OPTION_LETTERS[i]);
                option.SuccessOutcome.Reward.RewardValue = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_WINNUMBER, OPTION_LETTERS[i]);

                option.FailureOutcome = new EventOutcome();
                option.FailureOutcome.Reward = new Reward();
                option.FailureOutcome.Message = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_FAILURE, OPTION_LETTERS[i]);
                option.FailureOutcome.Reward.RewardType = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_FAILPRIZE, OPTION_LETTERS[i]);
                option.FailureOutcome.Reward.RewardValue = propBag.TryGetItoOptionValue(ITOFieldNames.OPTION_FAILNUMBER, OPTION_LETTERS[i]);
                tmpList.Add(option);
            }

            card.EventOptions = tmpList.ToArray();
            return card;
        }

        #region ITO Reading/Writing
        private static void WriteItoProperty(this StringBuilder sb, string propName, string value)
        {
            sb.Append(propName);
            sb.Append("=\"");
            sb.Append(EscapeItoValue(value));
            sb.AppendLine("\"");
        }

        private static void WriteItoOptionProperty(this StringBuilder sb, string[] propName, char propLetter, string value)
        {
            sb.WriteItoOptionProperty(propName[0], propLetter, value);
        }

        private static void WriteItoOptionProperty(this StringBuilder sb, string propName, char propLetter, string value)
        {
            sb.Append(propName);
            sb.Append(propLetter);
            sb.Append("=\"");
            sb.Append(EscapeItoValue(value));
            sb.AppendLine("\"");
        }

        private static string UnescapeItoValue(string value)
        {
            return value.Substring(1, value.Length - 2).Replace("#", Environment.NewLine);
        }

        private static string EscapeItoValue(string value)
        {
            return value.Replace(Environment.NewLine, "#")
                        .Replace("\"", "'"); // I don't think ITO has a control escape character...? 
                                             // Not sure what else to replace double quotes with, this seems like a fair compromise???
        }

        private static string TryGetItoValue(this Dictionary<string, string> dict, string itoPropName)
        {
            if (dict.ContainsKey(itoPropName))
                return dict[itoPropName];
            return null;
        }

        private static string TryGetItoOptionValue(this Dictionary<string, string> dict, string[] propNames, char propLetter)
        {
            foreach(var propName in propNames)
            {
                var result = dict.TryGetItoOptionValue(propName, propLetter);
                if (result != null)
                    return result;
            }
            return null;
        }

        private static string TryGetItoOptionValue(this Dictionary<string, string> dict, string propName, char propLetter)
        {
            return dict.TryGetItoValue(propName + propLetter);
        }
        #endregion

        private static class ITOFieldNames
        {
            public static readonly string EVENT_NAME = "name";
            public static readonly string EVENT_ABOUT = "about";
            public static readonly string EVENT_AUTHOR = "author";
            public static readonly string EVENT_CONTACT = "contact";
            public static readonly string EVENT_FLAVOR = "flavor";
            public static readonly string EVENT_LOCATION = "location";
            public static readonly string EVENT_OPTIONS = "options";
            public static readonly string EVENT_IMAGE = "image";

            public static readonly string OPTION = "option";
            public static readonly string OPTION_TEST = "test";
            public static readonly string OPTION_SUCCESS = "success";
            public static readonly string OPTION_WINPRIZE = "winprize";
            public static readonly string OPTION_WINNUMBER = "winnumber";
            public static readonly string[] OPTION_FAILURE = new string[] { "failure", "fail" };
            public static readonly string OPTION_FAILPRIZE = "failprize";
            public static readonly string OPTION_FAILNUMBER = "failnumber";
        }
    }

    #endregion
}

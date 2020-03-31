using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoH_CardEdit_NetFramework
{

    public partial class EventOptionUserControl : UserControl
    {
        [Category("Other"), Description("Title of the outer group box.")]
        public string OptionGroupBoxTitle
        {
            get { return this.container.Text; }
            set { this.container.Text = value; }
        }

        public EventOptionUserControl()
        {
            InitializeComponent();

            PopulateCheckTypes();
            PopulateRewardTypes(this.successRewardType);
            PopulateRewardTypes(this.failureRewardType);
        }

        #region Data Extraction/Loading
        public EventOption GetEventOption()
        {
            var option = new EventOption();
            option.ButtonText = buttonText.Text;
            option.CheckType = checkType.Text.ToString();
            option.SuccessOutcome = GetSuccessOutcome();
            option.FailureOutcome = GetFailureOutcome();
            return option;
        }

        protected EventOutcome GetSuccessOutcome()
        {
            return GetEventOutcome(successText, successRewardType, successRewardValue);
        }

        protected EventOutcome GetFailureOutcome()
        {
            return GetEventOutcome(successText, failureRewardType, failureRewardValue);
        }

        protected EventOutcome GetEventOutcome(TextBox message, ComboBox rewardType, ComboBox rewardValue)
        {
            var outcome = new EventOutcome();
            outcome.Message = message.Text;
            outcome.Reward = new Reward();
            outcome.Reward.RewardType = rewardType.Text.ToString();
            outcome.Reward.RewardValue = rewardValue.Text.ToString();
            return outcome;
        }

        public void SetEventOption(EventOption option)
        {
            this.buttonText.Text = option.ButtonText;
            this.checkType.SelectItemByText(option.CheckType);
            SetSuccessOutcome(option.SuccessOutcome);
            SetFailureOutcome(option.FailureOutcome);
        }

        protected void SetSuccessOutcome(EventOutcome outcome)
        {
            SetEventOutcome(outcome, successText, successRewardType, successRewardValue);
        }

        protected void SetFailureOutcome(EventOutcome outcome)
        {
            SetEventOutcome(outcome, failureText, failureRewardType, failureRewardValue);
        }

        protected void SetEventOutcome(EventOutcome outcome, TextBox message, ComboBox rewardType, ComboBox rewardValue)
        {
            message.Text = outcome.Message;
            rewardType.SelectItemByText(outcome.Reward.RewardType);
            rewardValue.SelectItemByText(outcome.Reward.RewardValue);
        }
        #endregion

        #region Data Population
        protected void PopulateCheckTypes()
        {
            this.checkType.Items.Clear();
            this.checkType.Items.AddRange(DataAccess.Instance.CheckTypes);
        }

        protected void PopulateRewardTypes(ComboBox rewardTypeComboBox)
        {
            rewardTypeComboBox.Items.Clear();
            rewardTypeComboBox.DataSource = DataAccess.Instance.RewardTypes.Clone();
            rewardTypeComboBox.DisplayMember = "Name";
            rewardTypeComboBox.ValueMember = "Name";
        }

        protected void PopulateRewardValues(ComboBox rewardOptionsComboBox, string[] options)
        {
            if (options == null || options.Length == 0)
                rewardOptionsComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            else
            {
                rewardOptionsComboBox.DataSource = options;
                rewardOptionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        #endregion

        #region Friggin' Events
        private void OnSuccessRewardTypeChanged(object sender, EventArgs e)
        {
            var selectedItem = (sender as ComboBox).SelectedItem as RewardType;
            if (selectedItem != null)
                this.PopulateRewardValues(this.successRewardValue, selectedItem.LookupValues);
        }

        private void OnFailureRewardTypeChanged(object sender, EventArgs e)
        {
            var selectedItem = (sender as ComboBox).SelectedItem as RewardType;
            if (selectedItem != null)
                this.PopulateRewardValues(this.failureRewardValue, selectedItem.LookupValues);
        }
        #endregion
    }
}

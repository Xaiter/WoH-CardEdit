using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoH_CardEdit_NetFramework
{
    public partial class EditEventCard : Form
    {
        protected EventOptionUserControl[] eventOptionPanels;

        public EditEventCard()
        {
            InitializeComponent();
            this.eventOptionPanels = new EventOptionUserControl[] { this.eventOption1, this.eventOption2, this.eventOption3 };
            this.optionCount.SelectedIndex = 0;
            this.eventLocation.DataSource = DataAccess.Instance.Locations;
        }

        private void OnOptionCountChanged(object sender, EventArgs e)
        {
            int val = GetOptionCount(sender as ComboBox);
            for(var i = 0; i < this.eventOptionPanels.Length; i++)
            {
                this.eventOptionPanels[i].Enabled = i < val;
            }
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var d = new SaveFileDialog();
            d.Filter = "ITO Files (.ito)|*.ito";
            d.InitialDirectory = Environment.ExpandEnvironmentVariables("%localappdata%\\wohgame\\custom");

            if (d.ShowDialog() != DialogResult.OK)
                return;

            var card = new EventCard();
            card.EventTitle = eventTitle.Text;
            card.About = about.Text;
            card.Author = author.Text;
            card.Contact = contact.Text;
            card.EventText = eventText.Text;
            card.Location = eventLocation.Text;
            card.IsBigImage = isBigImage.Checked;
            card.ImagePath = imagePath.Text;

            var optCount = this.GetOptionCount(optionCount);
            card.EventOptions = this.eventOptionPanels.Take(optCount).Select(p => p.GetEventOption()).ToArray();
            DataAccess.Instance.SaveITOFile(d.FileName, card);
        }

        private void OnLoadClicked(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "ITO Files (.ito)|*.ito";
            d.InitialDirectory = Environment.ExpandEnvironmentVariables("%localappdata%\\wohgame\\custom");
            d.Multiselect = false;

            if (d.ShowDialog() != DialogResult.OK)
                return;

            var card = DataAccess.Instance.LoadITOFile(d.FileName);
            this.eventTitle.Text = card.EventTitle;
            this.about.Text = card.About;
            this.author.Text = card.Author;
            this.contact.Text = card.Contact;
            this.eventText.Text = card.EventText;
            this.eventLocation.SelectedItem = card.Location;
            this.isBigImage.Checked = card.IsBigImage;
            this.imagePath.Text = card.ImagePath;

            this.optionCount.SelectedItem = card.EventOptions.Length.ToString();
            for (var i = 0; i < card.EventOptions.Length; i++)
                this.eventOptionPanels[i].SetEventOption(card.EventOptions[i]);
        }

        protected int GetOptionCount(ComboBox sender)
        {
            int val = 0;
            if (!int.TryParse(sender.SelectedItem as string, out val))
                return 1;
            return val;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoH_CardEdit_NetFramework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var window = new EditEventCard();
            Application.Run(window);
        }
    }

    internal static class WinFormsHelperExtensions
    {
        public static void SelectItemByText(this ComboBox comboBox, string text)
        {
            var index = comboBox.FindStringExact(text);
            if (index != -1)
                comboBox.SelectedIndex = index;

            if (comboBox.DropDownStyle == ComboBoxStyle.DropDown)
                comboBox.Text = text;
        }
    }
}

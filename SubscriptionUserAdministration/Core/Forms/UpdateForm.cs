using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;
using System.Text.RegularExpressions;

namespace SubscriptionUserAdministration.Core.Forms
{
    public partial class UpdateForm : Form
    {
        UserModel sub;
        public UpdateForm(UserModel subscriber)
        {
            sub = subscriber;
            InitializeComponent(subscriber);
        }

        private async void UpdateButton_Click(object sender, EventArgs args)
        {
            await QueryHolder.Update(new UserModel(sub.Id, nameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text
                , expiriationDateCalendar.SelectionStart, sub.IsExpired));
            Close();
        }
        private void BackButton_Click(object sender, EventArgs args) => Close();
        private void DateChangedByUser(object sender, DateRangeEventArgs args)
        {
            if (expiriationDateCalendar.SelectionStart < sub.SubExpiriationDate)
                expiriationDateCalendar.SetDate(sub.SubExpiriationDate);
        }
        private void OnlyDigitKeyAllowed_KeyPress(object sender, KeyPressEventArgs args)
        {
            if (args.KeyChar <= 47 || args.KeyChar >= 58)
            {
                if (args.KeyChar == 8)
                {
                    args.Handled = false;
                    return;
                }
                args.Handled = true;
            }
        }

        private void OnlyCharKeyAllowed_KeyPress(Object sender, KeyPressEventArgs args)
        {
            String str = args.KeyChar.ToString();
            if (!Regex.Match(str, @"[a-zA-ZА-Яа-я\b]").Success)
                args.Handled = true;
        }
    }
}

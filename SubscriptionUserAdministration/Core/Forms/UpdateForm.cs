using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;
using System.Text.RegularExpressions;

namespace SubscriptionUserAdministration.Core.Forms
{
    public sealed partial class UpdateForm : Form
    {
        private readonly UserModel sub;
        public UpdateForm(UserModel subscriber)
        {
            sub = subscriber;
            InitializeComponent(subscriber);
        }
        private async void UpdateButton_Click(object sender, EventArgs args)
        {
            Int32 id = sub.Id;
            String name = nameTextBox.Text.Trim();
            String lastName = lastNameTextBox.Text.Trim();
            String phoneNumber = phoneNumberTextBox.Text.Trim();
            DateTime subExpiriationDate = expiriationDateCalendar.SelectionStart;
            Boolean isExpired = sub.IsExpired;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Все поля должны быть заполнены!","Ошибка ввода");
                nameTextBox.Text = sub.Name;
                lastNameTextBox.Text = sub.LastName;
                phoneNumberTextBox.Text = sub.PhoneNumber;
            }
            else
            {
                await QueryHolder.Update(new UserModel(id, name, lastName, phoneNumber, subExpiriationDate, isExpired));
                MessageBox.Show("Данные успешно обновлены");
                Close();
            }
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

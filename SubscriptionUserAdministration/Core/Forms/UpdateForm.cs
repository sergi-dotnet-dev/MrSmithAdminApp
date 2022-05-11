using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;

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
    }
}

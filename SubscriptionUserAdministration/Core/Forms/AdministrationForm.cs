using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SubscriptionUserAdministration.Core.Forms
{
    public sealed partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();
            UpdateSubCount();
        }
        public void UpdateSubCount()
        {
            Int32 minFreeID = QueryHolder.GetMinFreeId();

            if (minFreeID == 0)
                this.currentSubInDBLabel.Text = $"Подписичков пока нет :(\n Идентификатор нового - 0";
            else
                currentSubInDBLabel.Text = $"Ближайший свободный идентификатор: {minFreeID}\n Пожалуйста, воспользуйтесь им";

            subIdTextBox.Text = minFreeID.ToString();
        }
        private async void CreateButton_Click(Object sender, EventArgs args)
        {
            if (String.IsNullOrEmpty(subIdTextBox.Text) || String.IsNullOrEmpty(subNameTextBox.Text)
                || String.IsNullOrEmpty(subLastNameTextBox.Text) || String.IsNullOrEmpty(subPhoneNumberTextBox.Text)
                || subStartDateChooseCalendar.SelectionStart < DateTime.Today)
            {
                String nullAttentionMessageText = "Все поля обязательны к заполнению";
                String caption = "Ошибка ввода";
                MessageBox.Show(nullAttentionMessageText, caption, MessageBoxButtons.OK);

                subIdTextBox.Clear();
                subNameTextBox.Clear();
                subLastNameTextBox.Clear();
                subPhoneNumberTextBox.Clear();
                subStartDateChooseCalendar.SelectionStart = DateTime.Now;
            }
            else
            {
                Int32 id = Convert.ToInt32(subIdTextBox.Text.Trim());
                String name = subNameTextBox.Text.Trim();
                String lastName = subLastNameTextBox.Text.Trim();
                String phoneNumber = subPhoneNumberTextBox.Text.Trim();
                DateTime expiriationDate = subStartDateChooseCalendar.SelectionStart.AddDays(30);

                await QueryHolder.Create(new Models.UserModel(id, name, lastName, phoneNumber, expiriationDate));
                await QueryHolder.Pop(id);
                UpdateSubCount();

                subIdTextBox.Clear();
                subNameTextBox.Clear();
                subLastNameTextBox.Clear();
                subPhoneNumberTextBox.Clear();
                subStartDateChooseCalendar.SelectionStart = DateTime.Now;
            }
        }
        private void ReadButton_Click(object sender, EventArgs args)
        {
            if (!String.IsNullOrEmpty(subIdTextBox.Text))
            {
                Int32 id = Convert.ToInt32(subIdTextBox.Text.Trim());
                subIdTextBox.Clear();

                var subscriber = QueryHolder.Read(id);
                if (String.IsNullOrEmpty(subscriber.Name))
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
                ReadFromDB readFromDB = new ReadFromDB(this, subscriber);
                readFromDB.Show();
            }
            else if (!String.IsNullOrEmpty(subPhoneNumberTextBox.Text))
            {
                String phoneNumber = subPhoneNumberTextBox.Text.Trim();
                subPhoneNumberTextBox.Clear();

                var subscriber = QueryHolder.Read(phoneNumber);
                if (String.IsNullOrEmpty(subscriber.Name))
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
                ReadFromDB readFromDB = new ReadFromDB(this, subscriber);
                readFromDB.Show();
            }
            else
            {
                String nullAttentionMessageText = "Поиск только по ID или номеру телефона. Заполните поля корректно";
                String caption = "Ошибка ввода";
                MessageBox.Show(nullAttentionMessageText, caption, MessageBoxButtons.OK);
                subIdTextBox.Clear();
                subPhoneNumberTextBox.Clear();
            }
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
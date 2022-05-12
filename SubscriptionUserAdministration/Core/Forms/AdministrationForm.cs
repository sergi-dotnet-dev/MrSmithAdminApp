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
        }
        private async void InitializeSubscriber()
        {
            if (!File.Exists("lastSub.json"))
            {
                this.currentSubInDBLabel.Text = String.Empty;
                return;
            }
            using (FileStream fs = new FileStream("lastSub.json", FileMode.Open))
            {
                UserModel? sub = await JsonSerializer.DeserializeAsync<UserModel>(fs);

                var currentSubCount = (sub.Id + 1).ToString();
                this.currentSubInDBLabel.Text = $"Количество пользователей в базе: {currentSubCount}\n" +
                    $"Идентификатор нового - {currentSubCount}";
                this.subIdTextBox.Text = currentSubCount;
            }
            File.Delete("lastSub.json");
        }
        private async void AdministrationForm_Shown(object sender, EventArgs args)
        {
            await QueryHolder.Read();
            InitializeSubscriber();
        }

        private async void CreateButton_Click(object sender, EventArgs args)
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

                subIdTextBox.Clear();
                subNameTextBox.Clear();
                subLastNameTextBox.Clear();
                subPhoneNumberTextBox.Clear();
                subStartDateChooseCalendar.SelectionStart = DateTime.Now;
            }
        }
        private async void ReadButton_Click(object sender, EventArgs args)
        {
            if (!String.IsNullOrEmpty(subIdTextBox.Text))
            {
                Int32 id = Convert.ToInt32(subIdTextBox.Text.Trim());
                subIdTextBox.Clear();

                await QueryHolder.Read(id);
                ReadFromDB readFromDB = new ReadFromDB();
                readFromDB.Show();
            }
            else if (!String.IsNullOrEmpty(subPhoneNumberTextBox.Text))
            {
                String phoneNumber = subPhoneNumberTextBox.Text.Trim();
                subPhoneNumberTextBox.Clear();

                await QueryHolder.Read(phoneNumber);
                ReadFromDB readFromDB = new ReadFromDB();
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
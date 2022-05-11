﻿using SubscriptionUserAdministration.Core.Queries;

namespace SubscriptionUserAdministration.Core.Forms
{
    public sealed partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void AdministrationForm_Load(object sender, EventArgs args)
        {

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
    }
}
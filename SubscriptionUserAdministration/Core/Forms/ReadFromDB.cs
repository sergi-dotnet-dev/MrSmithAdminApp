using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;
using System.Text.Json;

namespace SubscriptionUserAdministration.Core.Forms;
public sealed partial class ReadFromDB : Form
{
    public ReadFromDB()
    {
        InitializeComponent();
        InitializeSubscriber();
    }
    private async void InitializeSubscriber()
    {
        if (!File.Exists("subscriber.json"))
        {
            MessageBox.Show("Пользователь не найден");
            return;
        }
        using (FileStream fs = new FileStream("subscriber.json", FileMode.Open))
        {
            UserModel? sub = await JsonSerializer.DeserializeAsync<UserModel>(fs);
            idValueLabel.Text = sub.Id.ToString();
            nameValueLabel.Text = sub.Name;
            lastNameValueLabel.Text = sub.LastName;
            phoneNumberValueLabel.Text = sub.PhoneNumber;
            expiriationDateValueLabel.Text = sub.SubExpiriationDate.ToShortDateString();
        }
        File.Delete("subscriber.json");
    }
    private void UpdateButton_Click(object sender, EventArgs args)
    {
        UserModel subscriber = new UserModel(Convert.ToInt32(idValueLabel.Text), nameValueLabel.Text,
            lastNameValueLabel.Text, phoneNumberValueLabel.Text, Convert.ToDateTime(expiriationDateValueLabel.Text));
        UpdateForm updForm = new UpdateForm(subscriber);
        updForm.Show();
        Close();
    }
    private async void DeleteButton_Click(object sender, EventArgs args)
    {
        UserModel subscriber = new UserModel(Convert.ToInt32(idValueLabel.Text), nameValueLabel.Text,
            lastNameValueLabel.Text, phoneNumberValueLabel.Text, Convert.ToDateTime(expiriationDateValueLabel.Text));

        DialogResult dialogResult = MessageBox.Show($"Удалить пользователя?:\n{subscriber.Id}\t{subscriber.Name}\t{subscriber.LastName}", "Подтверждение", MessageBoxButtons.OKCancel);
        if (dialogResult == DialogResult.OK)
            await QueryHolder.Delete(subscriber);

        Close();
    }
    private void BackButton_Click(object sender, EventArgs args) => Close();

    private void ReadFromDB_Load(object sender, EventArgs args)
    {
        if (String.IsNullOrEmpty(nameValueLabel.Text)) 
            Close();
    }
}

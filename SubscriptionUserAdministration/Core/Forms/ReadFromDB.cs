using SubscriptionUserAdministration.Core.Models;
using SubscriptionUserAdministration.Core.Queries;
using System.Text.Json;

namespace SubscriptionUserAdministration.Core.Forms;

public sealed partial class ReadFromDB : Form
{
    private readonly AdministrationForm administrationForm;
    private readonly UserModel subscriber;
    public ReadFromDB(AdministrationForm administrationForm, UserModel subscriber)
    {
        InitializeComponent();
        this.administrationForm = administrationForm;
        this.subscriber = subscriber;
        InitializeSubscriber();
    }
    private void InitializeSubscriber()
    {
        idValueLabel.Text = subscriber.Id.ToString();
        nameValueLabel.Text = subscriber.Name;
        lastNameValueLabel.Text = subscriber.LastName;
        phoneNumberValueLabel.Text = subscriber.PhoneNumber;
        expiriationDateValueLabel.Text = subscriber.SubExpiriationDate.ToShortDateString();
    }
    private void UpdateButton_Click(object sender, EventArgs args)
    {
        UserModel subscriber = new UserModel(Convert.ToInt32(idValueLabel.Text), nameValueLabel.Text,
            lastNameValueLabel.Text, phoneNumberValueLabel.Text, Convert.ToDateTime(expiriationDateValueLabel.Text));
        UpdateForm updForm = new UpdateForm(subscriber);
        updForm.Show();

        Close();
        Dispose();
    }
    private async void DeleteButton_Click(object sender, EventArgs args)
    {
        UserModel subscriber = new UserModel(Convert.ToInt32(idValueLabel.Text), nameValueLabel.Text,
            lastNameValueLabel.Text, phoneNumberValueLabel.Text, Convert.ToDateTime(expiriationDateValueLabel.Text));

        DialogResult dialogResult = MessageBox.Show($"Удалить пользователя?:\n{subscriber.Id}\t{subscriber.Name}\t{subscriber.LastName}",
            "Подтверждение", MessageBoxButtons.OKCancel);
        if (dialogResult == DialogResult.OK)
        {
            await QueryHolder.Delete(subscriber);
            await QueryHolder.Push(subscriber.Id);

            administrationForm.UpdateSubCount();
            MessageBox.Show("Пользователь успешно удален");
        }
        Close();
        Dispose();
    }
    private void BackButton_Click(object sender, EventArgs args) => Close();
}
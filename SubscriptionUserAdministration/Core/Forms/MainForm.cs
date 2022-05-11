namespace SubscriptionUserAdministration.Core.Forms;

public partial class MainForm : Form
{
    private static string Login = "admin";
    private static string Password = "99118";
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void AcceptButton_Click(object sender, EventArgs args)
    {
        if (loginTextBox.Text.Trim() == Login && passwordTextBox.Text.Trim() == Password)
        {
            this.Visible = false;
            AdministrationForm administrationForm = new AdministrationForm();
            administrationForm.Visible = false;
            administrationForm.ShowDialog();
        }
        loginTextBox.Clear();
        passwordTextBox.Clear();
    }
}

namespace SubscriptionUserAdministration.Core.Forms;

public partial class MainForm : Form
{
    private static readonly string Login = "admin";
    private static readonly string Password = "99118";
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
            administrationForm.Show();
        }
        loginTextBox.Clear();
        passwordTextBox.Clear();
    }
}

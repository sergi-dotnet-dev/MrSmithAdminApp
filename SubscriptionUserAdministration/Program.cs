namespace SubscriptionUserAdministration.Core.Forms;

internal static class Program
{

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        MainForm mainForm = new MainForm();
        Application.Run(mainForm);
    }
}

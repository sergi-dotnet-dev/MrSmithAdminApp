namespace SubscriptionUserAdministration.Core.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Location = new System.Drawing.Point(165, 79);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(88, 15);
            this.authorizationLabel.TabIndex = 0;
            this.authorizationLabel.Text = "Авторизуйтесь";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.Location = new System.Drawing.Point(152, 117);
            this.loginTextBox.MaxLength = 12;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(112, 23);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Location = new System.Drawing.Point(152, 167);
            this.passwordTextBox.MaxLength = 12;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(112, 23);
            this.passwordTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(108, 119);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(37, 15);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(89, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.acceptButton.Location = new System.Drawing.Point(165, 216);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Ok";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 277);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.authorizationLabel);
            this.CenterToScreen();
            this.Name = "MainForm";
            this.Text = "Мистер Смит";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label authorizationLabel;
    private TextBox loginTextBox;
    private TextBox passwordTextBox;
    private Label loginLabel;
    private Label passwordLabel;
    private Button acceptButton;
}

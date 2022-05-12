using SubscriptionUserAdministration.Core.Models;

namespace SubscriptionUserAdministration.Core.Forms;

sealed partial class ReadFromDB
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameValueLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberValueLabel = new System.Windows.Forms.Label();
            this.expiriationDateLabel = new System.Windows.Forms.Label();
            this.expiriationDateValueLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(44, 38);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(111, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID подписчика";
            // 
            // idValueLabel
            // 
            this.idValueLabel.AutoSize = true;
            this.idValueLabel.Location = new System.Drawing.Point(283, 38);
            this.idValueLabel.Name = "idValueLabel";
            this.idValueLabel.Size = new System.Drawing.Size(0, 20);
            this.idValueLabel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Location = new System.Drawing.Point(283, 75);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(0, 20);
            this.nameValueLabel.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 120);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // lastNameValueLabel
            // 
            this.lastNameValueLabel.AutoSize = true;
            this.lastNameValueLabel.Location = new System.Drawing.Point(283, 120);
            this.lastNameValueLabel.Name = "lastNameValueLabel";
            this.lastNameValueLabel.Size = new System.Drawing.Size(0, 20);
            this.lastNameValueLabel.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(44, 171);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(127, 20);
            this.phoneNumberLabel.TabIndex = 6;
            this.phoneNumberLabel.Text = "Номер телефона";
            // 
            // phoneNumberValueLabel
            // 
            this.phoneNumberValueLabel.AutoSize = true;
            this.phoneNumberValueLabel.Location = new System.Drawing.Point(283, 171);
            this.phoneNumberValueLabel.Name = "phoneNumberValueLabel";
            this.phoneNumberValueLabel.Size = new System.Drawing.Size(0, 20);
            this.phoneNumberValueLabel.TabIndex = 7;
            // 
            // expiriationDateLabel
            // 
            this.expiriationDateLabel.AutoSize = true;
            this.expiriationDateLabel.Location = new System.Drawing.Point(44, 219);
            this.expiriationDateLabel.Name = "expiriationDateLabel";
            this.expiriationDateLabel.Size = new System.Drawing.Size(192, 20);
            this.expiriationDateLabel.TabIndex = 8;
            this.expiriationDateLabel.Text = "Дата окончания подписки";
            // 
            // expiriationDateValueLabel
            // 
            this.expiriationDateValueLabel.AutoSize = true;
            this.expiriationDateValueLabel.Location = new System.Drawing.Point(283, 219);
            this.expiriationDateValueLabel.Name = "expiriationDateValueLabel";
            this.expiriationDateValueLabel.Size = new System.Drawing.Size(0, 20);
            this.expiriationDateValueLabel.TabIndex = 9;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(44, 294);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Enabled = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(144, 294);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Enabled = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(244, 294);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ReadFromDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 367);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.expiriationDateValueLabel);
            this.Controls.Add(this.expiriationDateLabel);
            this.Controls.Add(this.phoneNumberValueLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameValueLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idValueLabel);
            this.Controls.Add(this.idLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.CenterToScreen();
            this.Name = "ReadFromDB";
            this.Text = "Мистер Смит";
            this.Shown += new System.EventHandler(this.ReadFromDB_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    #endregion

    private Label idLabel;
    private Label idValueLabel;
    private Label nameLabel;
    private Label nameValueLabel;
    private Label lastNameLabel;
    private Label lastNameValueLabel;
    private Label phoneNumberLabel;
    private Label phoneNumberValueLabel;
    private Label expiriationDateLabel;
    private Label expiriationDateValueLabel;
    private Button UpdateButton;
    private Button DeleteButton;
    private Button BackButton;
}

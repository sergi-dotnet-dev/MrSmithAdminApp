using SubscriptionUserAdministration.Core.Models;

namespace SubscriptionUserAdministration.Core.Forms
{
    partial class UpdateForm
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

        private void InitializeComponent(UserModel sub)
        {
            this.updateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.expiriationDateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.expiriationDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(32, 312);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 29);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Изменить данные";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(53, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(53, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(53, 107);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(53, 157);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(127, 20);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Номер телефона";
            // 
            // expiriationDateLabel
            // 
            this.expiriationDateLabel.AutoSize = true;
            this.expiriationDateLabel.Location = new System.Drawing.Point(53, 208);
            this.expiriationDateLabel.Name = "expiriationDateLabel";
            this.expiriationDateLabel.Size = new System.Drawing.Size(192, 20);
            this.expiriationDateLabel.TabIndex = 5;
            this.expiriationDateLabel.Text = "Дата окончания подписки";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(259, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Text = sub.Name;
            this.nameTextBox.KeyPress += new KeyPressEventHandler(this.OnlyCharKeyAllowed_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(259, 107);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.lastNameTextBox.TabIndex = 7;
            this.lastNameTextBox.Text = sub.LastName;
            this.lastNameTextBox.KeyPress += new KeyPressEventHandler(this.OnlyCharKeyAllowed_KeyPress);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(259, 157);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.phoneNumberTextBox.TabIndex = 8;
            this.phoneNumberTextBox.Text = sub.PhoneNumber;
            this.phoneNumberTextBox.KeyPress += new KeyPressEventHandler(this.OnlyDigitKeyAllowed_KeyPress);
            // 
            // expiriationDateCalendar
            // 
            this.expiriationDateCalendar.Location = new System.Drawing.Point(257, 208);
            this.expiriationDateCalendar.Name = "expiriationDateCalendar";
            this.expiriationDateCalendar.TabIndex = 9;
            this.expiriationDateCalendar.SetDate(sub.SubExpiriationDate);
            this.expiriationDateCalendar.MaxSelectionCount = 1;
            this.expiriationDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateChangedByUser);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 449);
            this.ControlBox = false;
            this.Controls.Add(this.expiriationDateCalendar);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.expiriationDateLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateForm";
            this.Text = "Мистер Смит";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateButton;
        private Button backButton;
        private Label nameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private Label expiriationDateLabel;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private MonthCalendar expiriationDateCalendar;
    }
}
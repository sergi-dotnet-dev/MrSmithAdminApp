namespace SubscriptionUserAdministration.Core.Forms;

  sealed  partial class AdministrationForm
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
            this.subID = new System.Windows.Forms.Label();
            this.subStartDate = new System.Windows.Forms.Label();
            this.subPhoneNumber = new System.Windows.Forms.Label();
            this.subLastName = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.Label();
            this.subIdTextBox = new System.Windows.Forms.TextBox();
            this.subPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.subLastNameTextBox = new System.Windows.Forms.TextBox();
            this.subNameTextBox = new System.Windows.Forms.TextBox();
            this.subStartDateChooseCalendar = new System.Windows.Forms.MonthCalendar();
            this.createButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subID
            // 
            this.subID.AutoSize = true;
            this.subID.Location = new System.Drawing.Point(32, 72);
            this.subID.Name = "subID";
            this.subID.Size = new System.Drawing.Size(111, 20);
            this.subID.TabIndex = 0;
            this.subID.Text = "ID подписчика";
            // 
            // subStartDate
            // 
            this.subStartDate.AutoSize = true;
            this.subStartDate.Location = new System.Drawing.Point(399, 60);
            this.subStartDate.Name = "subStartDate";
            this.subStartDate.Size = new System.Drawing.Size(217, 20);
            this.subStartDate.TabIndex = 1;
            this.subStartDate.Text = "Начало действия абонемента";
            // 
            // subPhoneNumber
            // 
            this.subPhoneNumber.AutoSize = true;
            this.subPhoneNumber.Location = new System.Drawing.Point(32, 207);
            this.subPhoneNumber.Name = "subPhoneNumber";
            this.subPhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.subPhoneNumber.TabIndex = 2;
            this.subPhoneNumber.Text = "Номер телефона";
            // 
            // subLastName
            // 
            this.subLastName.AutoSize = true;
            this.subLastName.Location = new System.Drawing.Point(32, 161);
            this.subLastName.Name = "subLastName";
            this.subLastName.Size = new System.Drawing.Size(73, 20);
            this.subLastName.TabIndex = 3;
            this.subLastName.Text = "Фамилия";
            // 
            // subName
            // 
            this.subName.AutoSize = true;
            this.subName.Location = new System.Drawing.Point(32, 118);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(39, 20);
            this.subName.TabIndex = 4;
            this.subName.Text = "Имя";
            // 
            // subIdTextBox
            // 
            this.subIdTextBox.Location = new System.Drawing.Point(216, 65);
            this.subIdTextBox.MaxLength = 999;
            this.subIdTextBox.Name = "subIdTextBox";
            this.subIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.subIdTextBox.TabIndex = 5;
            // 
            // subPhoneNumberTextBox
            // 
            this.subPhoneNumberTextBox.Location = new System.Drawing.Point(216, 204);
            this.subPhoneNumberTextBox.MaxLength = 11;
            this.subPhoneNumberTextBox.Name = "subPhoneNumberTextBox";
            this.subPhoneNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.subPhoneNumberTextBox.TabIndex = 8;
            // 
            // subLastNameTextBox
            // 
            this.subLastNameTextBox.Location = new System.Drawing.Point(216, 154);
            this.subLastNameTextBox.MaxLength = 50;
            this.subLastNameTextBox.Name = "subLastNameTextBox";
            this.subLastNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.subLastNameTextBox.TabIndex = 7;
            // 
            // subNameTextBox
            // 
            this.subNameTextBox.Location = new System.Drawing.Point(216, 115);
            this.subNameTextBox.MaxLength = 50;
            this.subNameTextBox.Name = "subNameTextBox";
            this.subNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.subNameTextBox.TabIndex = 6;
            // 
            // subStartDateChooseCalendar
            // 
            this.subStartDateChooseCalendar.Location = new System.Drawing.Point(399, 89);
            this.subStartDateChooseCalendar.MaxSelectionCount = 1;
            this.subStartDateChooseCalendar.Name = "subStartDateChooseCalendar";
            this.subStartDateChooseCalendar.TabIndex = 9;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(32, 290);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 29);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(163, 290);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(94, 29);
            this.readButton.TabIndex = 11;
            this.readButton.Text = "Найти";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 385);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.subStartDateChooseCalendar);
            this.Controls.Add(this.subNameTextBox);
            this.Controls.Add(this.subLastNameTextBox);
            this.Controls.Add(this.subPhoneNumberTextBox);
            this.Controls.Add(this.subIdTextBox);
            this.Controls.Add(this.subName);
            this.Controls.Add(this.subLastName);
            this.Controls.Add(this.subPhoneNumber);
            this.Controls.Add(this.subStartDate);
            this.Controls.Add(this.subID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Мистер Смит";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label subID;
        private Label subStartDate;
        private Label subPhoneNumber;
        private Label subLastName;
        private Label subName;
        private TextBox subIdTextBox;
        private TextBox subPhoneNumberTextBox;
        private TextBox subLastNameTextBox;
        private TextBox subNameTextBox;
        private MonthCalendar subStartDateChooseCalendar;
        private Button createButton;
        private Button readButton;
    }

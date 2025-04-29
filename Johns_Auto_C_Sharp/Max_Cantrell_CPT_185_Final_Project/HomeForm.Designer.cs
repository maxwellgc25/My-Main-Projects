namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            dispUserLabel = new Label();
            label3 = new Label();
            label5 = new Label();
            submitCarButton = new Button();
            submitCustButton = new Button();
            partsOrderButton = new Button();
            workCarButton = new Button();
            upcomingApptButton = new Button();
            calendarButton = new Button();
            contactsButton = new Button();
            userInfoButton = new Button();
            manageButton = new Button();
            logOutButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dispUserLabel
            // 
            dispUserLabel.AutoSize = true;
            dispUserLabel.Location = new Point(1000, 13);
            dispUserLabel.Name = "dispUserLabel";
            dispUserLabel.Size = new Size(115, 23);
            dispUserLabel.TabIndex = 1;
            dispUserLabel.Text = "User: James";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(875, 59);
            label3.Name = "label3";
            label3.Size = new Size(254, 69);
            label3.TabIndex = 2;
            label3.Text = "               Shop Info:\r\n6875 SC-9, Inman, SC, 29349\r\n          (864)-814-2070";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(900, 140);
            label5.Name = "label5";
            label5.Size = new Size(215, 92);
            label5.TabIndex = 4;
            label5.Text = "              Hours:\r\nMon-Thurs:   8AM-5PM\r\nFri:                 8AM-3PM\r\nSat-Sun:           Closed";
            // 
            // submitCarButton
            // 
            submitCarButton.BackColor = Color.Moccasin;
            submitCarButton.FlatAppearance.BorderSize = 2;
            submitCarButton.FlatStyle = FlatStyle.Flat;
            submitCarButton.ForeColor = SystemColors.ControlText;
            submitCarButton.Location = new Point(121, 131);
            submitCarButton.Name = "submitCarButton";
            submitCarButton.Size = new Size(196, 75);
            submitCarButton.TabIndex = 5;
            submitCarButton.Text = "Submit Car For Service";
            submitCarButton.UseVisualStyleBackColor = false;
            submitCarButton.Click += submitCarButton_Click;
            // 
            // submitCustButton
            // 
            submitCustButton.BackColor = Color.Moccasin;
            submitCustButton.FlatAppearance.BorderSize = 2;
            submitCustButton.FlatStyle = FlatStyle.Flat;
            submitCustButton.ForeColor = SystemColors.ControlText;
            submitCustButton.Location = new Point(121, 239);
            submitCustButton.Name = "submitCustButton";
            submitCustButton.Size = new Size(196, 75);
            submitCustButton.TabIndex = 6;
            submitCustButton.Text = "Browse Without Car For Service";
            submitCustButton.UseVisualStyleBackColor = false;
            submitCustButton.Click += submitCustButton_Click;
            // 
            // partsOrderButton
            // 
            partsOrderButton.BackColor = Color.Moccasin;
            partsOrderButton.FlatAppearance.BorderSize = 2;
            partsOrderButton.FlatStyle = FlatStyle.Flat;
            partsOrderButton.ForeColor = SystemColors.ControlText;
            partsOrderButton.Location = new Point(121, 343);
            partsOrderButton.Name = "partsOrderButton";
            partsOrderButton.Size = new Size(196, 75);
            partsOrderButton.TabIndex = 7;
            partsOrderButton.Text = "Parts Order List:";
            partsOrderButton.UseVisualStyleBackColor = false;
            partsOrderButton.Click += partsOrderButton_Click;
            // 
            // workCarButton
            // 
            workCarButton.BackColor = Color.Moccasin;
            workCarButton.FlatAppearance.BorderSize = 2;
            workCarButton.FlatStyle = FlatStyle.Flat;
            workCarButton.ForeColor = SystemColors.ControlText;
            workCarButton.Location = new Point(352, 131);
            workCarButton.Name = "workCarButton";
            workCarButton.Size = new Size(196, 75);
            workCarButton.TabIndex = 8;
            workCarButton.Text = "Working Car Progress:";
            workCarButton.UseVisualStyleBackColor = false;
            workCarButton.Click += workCarButton_Click;
            // 
            // upcomingApptButton
            // 
            upcomingApptButton.BackColor = Color.Moccasin;
            upcomingApptButton.FlatAppearance.BorderSize = 2;
            upcomingApptButton.FlatStyle = FlatStyle.Flat;
            upcomingApptButton.ForeColor = SystemColors.ControlText;
            upcomingApptButton.Location = new Point(352, 239);
            upcomingApptButton.Name = "upcomingApptButton";
            upcomingApptButton.Size = new Size(196, 75);
            upcomingApptButton.TabIndex = 9;
            upcomingApptButton.Text = "Upcoming Appointments:";
            upcomingApptButton.UseVisualStyleBackColor = false;
            upcomingApptButton.Click += upcomingApptButton_Click;
            // 
            // calendarButton
            // 
            calendarButton.BackColor = Color.Moccasin;
            calendarButton.FlatAppearance.BorderSize = 2;
            calendarButton.FlatStyle = FlatStyle.Flat;
            calendarButton.ForeColor = SystemColors.ControlText;
            calendarButton.Location = new Point(581, 131);
            calendarButton.Name = "calendarButton";
            calendarButton.Size = new Size(196, 75);
            calendarButton.TabIndex = 10;
            calendarButton.Text = "Calendar:";
            calendarButton.UseVisualStyleBackColor = false;
            calendarButton.Click += calendarButton_Click;
            // 
            // contactsButton
            // 
            contactsButton.BackColor = Color.Moccasin;
            contactsButton.FlatAppearance.BorderSize = 2;
            contactsButton.FlatStyle = FlatStyle.Flat;
            contactsButton.ForeColor = SystemColors.ControlText;
            contactsButton.Location = new Point(581, 239);
            contactsButton.Name = "contactsButton";
            contactsButton.Size = new Size(196, 75);
            contactsButton.TabIndex = 11;
            contactsButton.Text = "Contacts:";
            contactsButton.UseVisualStyleBackColor = false;
            contactsButton.Click += contactsButton_Click;
            // 
            // userInfoButton
            // 
            userInfoButton.BackColor = Color.Moccasin;
            userInfoButton.FlatAppearance.BorderColor = Color.Black;
            userInfoButton.FlatAppearance.BorderSize = 2;
            userInfoButton.FlatStyle = FlatStyle.Flat;
            userInfoButton.ForeColor = SystemColors.ControlText;
            userInfoButton.Location = new Point(352, 343);
            userInfoButton.Name = "userInfoButton";
            userInfoButton.Size = new Size(196, 75);
            userInfoButton.TabIndex = 12;
            userInfoButton.Text = "User Info:";
            userInfoButton.UseVisualStyleBackColor = false;
            userInfoButton.Click += userInfoButton_Click;
            // 
            // manageButton
            // 
            manageButton.BackColor = Color.Moccasin;
            manageButton.FlatAppearance.BorderSize = 2;
            manageButton.FlatStyle = FlatStyle.Flat;
            manageButton.ForeColor = SystemColors.ControlText;
            manageButton.Location = new Point(581, 343);
            manageButton.Name = "manageButton";
            manageButton.Size = new Size(196, 75);
            manageButton.TabIndex = 13;
            manageButton.Text = "Management Info:";
            manageButton.UseVisualStyleBackColor = false;
            manageButton.Click += manageButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(928, 438);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(151, 50);
            logOutButton.TabIndex = 14;
            logOutButton.Text = "Logout";
            toolTip1.SetToolTip(logOutButton, "Return to Login Screen");
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 27);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 15;
            label4.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(853, 252);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(276, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1163, 524);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(logOutButton);
            Controls.Add(manageButton);
            Controls.Add(userInfoButton);
            Controls.Add(contactsButton);
            Controls.Add(calendarButton);
            Controls.Add(upcomingApptButton);
            Controls.Add(workCarButton);
            Controls.Add(partsOrderButton);
            Controls.Add(submitCustButton);
            Controls.Add(submitCarButton);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dispUserLabel);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dispUserLabel;
        private Label label3;
        private Label label5;
        private Button submitCarButton;
        private Button submitCustButton;
        private Button partsOrderButton;
        private Button workCarButton;
        private Button upcomingApptButton;
        private Button calendarButton;
        private Button contactsButton;
        private Button userInfoButton;
        private Button manageButton;
        private Button logOutButton;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
    }
}
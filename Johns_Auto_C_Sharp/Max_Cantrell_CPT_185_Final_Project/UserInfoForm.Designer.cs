namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class UserInfoForm
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            clockInButton = new Button();
            startLunchButton = new Button();
            endLunchButton = new Button();
            clockOutButton = new Button();
            nameTextBox = new TextBox();
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            emailTextBox = new TextBox();
            hoursTextBox = new TextBox();
            label8 = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 23;
            label4.Text = "User Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1051, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 22;
            label2.Text = "User: James";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 21;
            label1.Text = "John's Auto Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(621, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 24;
            label3.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 168);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 25;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(621, 205);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 26;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(621, 243);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 27;
            label7.Text = "Email:";
            // 
            // clockInButton
            // 
            clockInButton.FlatAppearance.BorderSize = 2;
            clockInButton.FlatStyle = FlatStyle.Flat;
            clockInButton.Location = new Point(249, 99);
            clockInButton.Name = "clockInButton";
            clockInButton.Size = new Size(205, 46);
            clockInButton.TabIndex = 42;
            clockInButton.Text = "Clock In";
            clockInButton.UseVisualStyleBackColor = true;
            clockInButton.Click += clockInButton_Click;
            // 
            // startLunchButton
            // 
            startLunchButton.FlatAppearance.BorderSize = 2;
            startLunchButton.FlatStyle = FlatStyle.Flat;
            startLunchButton.Location = new Point(249, 160);
            startLunchButton.Name = "startLunchButton";
            startLunchButton.Size = new Size(205, 47);
            startLunchButton.TabIndex = 43;
            startLunchButton.Text = "Start Lunch";
            startLunchButton.UseVisualStyleBackColor = true;
            startLunchButton.Click += startLunchButton_Click;
            // 
            // endLunchButton
            // 
            endLunchButton.FlatAppearance.BorderSize = 2;
            endLunchButton.FlatStyle = FlatStyle.Flat;
            endLunchButton.Location = new Point(248, 221);
            endLunchButton.Name = "endLunchButton";
            endLunchButton.Size = new Size(205, 48);
            endLunchButton.TabIndex = 44;
            endLunchButton.Text = "End Lunch";
            endLunchButton.UseVisualStyleBackColor = true;
            endLunchButton.Click += endLunchButton_Click;
            // 
            // clockOutButton
            // 
            clockOutButton.FlatAppearance.BorderSize = 2;
            clockOutButton.FlatStyle = FlatStyle.Flat;
            clockOutButton.Location = new Point(248, 279);
            clockOutButton.Name = "clockOutButton";
            clockOutButton.Size = new Size(205, 45);
            clockOutButton.TabIndex = 45;
            clockOutButton.Text = "Clock Out";
            clockOutButton.UseVisualStyleBackColor = true;
            clockOutButton.Click += clockOutButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(693, 126);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(206, 30);
            nameTextBox.TabIndex = 46;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(729, 165);
            userTextBox.Name = "userTextBox";
            userTextBox.ReadOnly = true;
            userTextBox.Size = new Size(170, 30);
            userTextBox.TabIndex = 47;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(729, 201);
            passTextBox.Name = "passTextBox";
            passTextBox.ReadOnly = true;
            passTextBox.Size = new Size(170, 30);
            passTextBox.TabIndex = 48;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(693, 240);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(206, 30);
            emailTextBox.TabIndex = 49;
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(783, 276);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.ReadOnly = true;
            hoursTextBox.Size = new Size(116, 30);
            hoursTextBox.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 279);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 50;
            label8.Text = "Hours For Week:";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 2;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(961, 410);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(205, 35);
            closeButton.TabIndex = 53;
            closeButton.Text = "Back to Home Page";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1191, 457);
            Controls.Add(closeButton);
            Controls.Add(hoursTextBox);
            Controls.Add(label8);
            Controls.Add(emailTextBox);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(clockOutButton);
            Controls.Add(endLunchButton);
            Controls.Add(startLunchButton);
            Controls.Add(clockInButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            Load += UserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button clockInButton;
        private Button startLunchButton;
        private Button endLunchButton;
        private Button clockOutButton;
        private TextBox nameTextBox;
        private TextBox userTextBox;
        private TextBox passTextBox;
        private TextBox emailTextBox;
        private TextBox hoursTextBox;
        private Label label8;
        private Button closeButton;
    }
}
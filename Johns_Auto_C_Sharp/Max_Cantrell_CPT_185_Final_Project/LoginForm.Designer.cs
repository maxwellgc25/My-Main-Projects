namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userInTextBox = new TextBox();
            passInTextBox = new TextBox();
            loginButton = new Button();
            closeButton = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Please Log In:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "User:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // userInTextBox
            // 
            userInTextBox.Location = new Point(340, 196);
            userInTextBox.Margin = new Padding(4, 3, 4, 3);
            userInTextBox.Name = "userInTextBox";
            userInTextBox.Size = new Size(330, 33);
            userInTextBox.TabIndex = 4;
            // 
            // passInTextBox
            // 
            passInTextBox.Location = new Point(340, 280);
            passInTextBox.Margin = new Padding(4, 3, 4, 3);
            passInTextBox.Name = "passInTextBox";
            passInTextBox.Size = new Size(330, 33);
            passInTextBox.TabIndex = 5;
            passInTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(245, 382);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(222, 55);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            toolTip1.SetToolTip(loginButton, "Login to Home Page");
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(521, 382);
            closeButton.Margin = new Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(222, 55);
            closeButton.TabIndex = 7;
            closeButton.Text = "Exit";
            toolTip1.SetToolTip(closeButton, "Close the App");
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(367, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            CancelButton = closeButton;
            ClientSize = new Size(1006, 521);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            Controls.Add(loginButton);
            Controls.Add(passInTextBox);
            Controls.Add(userInTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userInTextBox;
        private TextBox passInTextBox;
        private Button loginButton;
        private Button closeButton;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
    }
}

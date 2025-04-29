namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class UpcomingForm
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
            closeButton = new Button();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            apptOutListBox = new ListBox();
            label3 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 25);
            label4.TabIndex = 20;
            label4.Text = "Upcoming Appointments:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1016, 21);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 19;
            label2.Text = "User: James";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 18;
            label1.Text = "John's Auto Service";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 2;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(924, 466);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(205, 35);
            closeButton.TabIndex = 52;
            closeButton.Text = "Back to Home Page";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(873, 79);
            label10.Name = "label10";
            label10.Size = new Size(80, 23);
            label10.TabIndex = 50;
            label10.Text = "Service:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(492, 79);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 48;
            label8.Text = "Year:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 79);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 47;
            label7.Text = "Model:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 79);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 46;
            label6.Text = "Make:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 79);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 45;
            label5.Text = "Owner:";
            // 
            // apptOutListBox
            // 
            apptOutListBox.FormattingEnabled = true;
            apptOutListBox.ItemHeight = 23;
            apptOutListBox.Location = new Point(63, 105);
            apptOutListBox.Name = "apptOutListBox";
            apptOutListBox.Size = new Size(1034, 326);
            apptOutListBox.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 79);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 55;
            label3.Text = "Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(749, 79);
            label9.Name = "label9";
            label9.Size = new Size(60, 23);
            label9.TabIndex = 56;
            label9.Text = "Time:";
            // 
            // UpcomingForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1162, 533);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(closeButton);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(apptOutListBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpcomingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button closeButton;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListBox apptOutListBox;
        private Label label3;
        private Label label9;
    }
}
namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class ProgressForm
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
            progressOutListBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            updateProgButton = new Button();
            closeButton = new Button();
            upProgTextBox = new TextBox();
            removeFromButton = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(231, 25);
            label4.TabIndex = 20;
            label4.Text = "Working Car Progress:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1012, 25);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 19;
            label2.Text = "User: James";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 18;
            label1.Text = "John's Auto Service";
            // 
            // progressOutListBox
            // 
            progressOutListBox.FormattingEnabled = true;
            progressOutListBox.ItemHeight = 23;
            progressOutListBox.Location = new Point(52, 110);
            progressOutListBox.Name = "progressOutListBox";
            progressOutListBox.Size = new Size(1034, 326);
            progressOutListBox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 84);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 23;
            label5.Text = "Owner:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 84);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 24;
            label6.Text = "Make:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 84);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 25;
            label7.Text = "Model:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 84);
            label8.Name = "label8";
            label8.Size = new Size(56, 23);
            label8.TabIndex = 26;
            label8.Text = "Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(624, 84);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 27;
            label9.Text = "Progress 0-5:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(813, 84);
            label10.Name = "label10";
            label10.Size = new Size(80, 23);
            label10.TabIndex = 28;
            label10.Text = "Service:";
            // 
            // updateProgButton
            // 
            updateProgButton.FlatAppearance.BorderSize = 2;
            updateProgButton.FlatStyle = FlatStyle.Flat;
            updateProgButton.Location = new Point(529, 482);
            updateProgButton.Name = "updateProgButton";
            updateProgButton.Size = new Size(294, 35);
            updateProgButton.TabIndex = 39;
            updateProgButton.Text = "Update Selected Car Progress";
            updateProgButton.UseVisualStyleBackColor = true;
            updateProgButton.Click += updateProgButton_Click;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 2;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(899, 482);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(205, 35);
            closeButton.TabIndex = 41;
            closeButton.Text = "Back to Home Page";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // upProgTextBox
            // 
            upProgTextBox.Location = new Point(449, 485);
            upProgTextBox.Name = "upProgTextBox";
            upProgTextBox.Size = new Size(74, 30);
            upProgTextBox.TabIndex = 42;
            // 
            // removeFromButton
            // 
            removeFromButton.FlatAppearance.BorderSize = 2;
            removeFromButton.FlatStyle = FlatStyle.Flat;
            removeFromButton.Location = new Point(38, 482);
            removeFromButton.Name = "removeFromButton";
            removeFromButton.Size = new Size(323, 35);
            removeFromButton.TabIndex = 43;
            removeFromButton.Text = "Remove Selected Car From Service";
            removeFromButton.UseVisualStyleBackColor = true;
            removeFromButton.Click += removeFromButton_Click;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1160, 557);
            Controls.Add(removeFromButton);
            Controls.Add(upProgTextBox);
            Controls.Add(closeButton);
            Controls.Add(updateProgButton);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(progressOutListBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProgressForm";
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            Load += ProgressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private ListBox progressOutListBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button updateProgButton;
        private Button closeButton;
        private TextBox upProgTextBox;
        private Button removeFromButton;
    }
}
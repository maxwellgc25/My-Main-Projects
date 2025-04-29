namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class ManageForm
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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 23);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 24;
            label4.Text = "Mangement Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(978, 25);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 23;
            label2.Text = "User: James";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 22;
            label1.Text = "John's Auto Service";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 2;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(912, 408);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(205, 35);
            closeButton.TabIndex = 43;
            closeButton.Text = "Back to Home Page";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1144, 455);
            Controls.Add(closeButton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            Load += ManageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button closeButton;
    }
}
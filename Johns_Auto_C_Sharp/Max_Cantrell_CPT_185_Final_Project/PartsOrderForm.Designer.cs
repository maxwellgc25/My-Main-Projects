namespace Max_Cantrell_CPT_185_Final_Project
{
    partial class PartsOrderForm
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
            label1 = new Label();
            label2 = new Label();
            ordersOutListBox = new ListBox();
            label4 = new Label();
            addToOrderButton = new Button();
            partTextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            goingOnTextBox = new TextBox();
            label6 = new Label();
            sourceTextBox = new TextBox();
            label7 = new Label();
            noteTextBox = new TextBox();
            removeButton = new Button();
            markOrderedButton = new Button();
            markInStockButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 1;
            label1.Text = "John's Auto Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1031, 16);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 2;
            label2.Text = "User: James";
            // 
            // ordersOutListBox
            // 
            ordersOutListBox.FormattingEnabled = true;
            ordersOutListBox.ItemHeight = 23;
            ordersOutListBox.Location = new Point(12, 141);
            ordersOutListBox.Name = "ordersOutListBox";
            ordersOutListBox.Size = new Size(1134, 418);
            ordersOutListBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 17;
            label4.Text = "Parts To Order:";
            // 
            // addToOrderButton
            // 
            addToOrderButton.FlatAppearance.BorderSize = 2;
            addToOrderButton.FlatStyle = FlatStyle.Flat;
            addToOrderButton.Location = new Point(946, 86);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(200, 35);
            addToOrderButton.TabIndex = 39;
            addToOrderButton.Text = "Add to Order List:";
            addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // partTextBox
            // 
            partTextBox.Location = new Point(27, 94);
            partTextBox.Name = "partTextBox";
            partTextBox.Size = new Size(201, 30);
            partTextBox.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 68);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 41;
            label3.Text = "Part / #:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 65);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 43;
            label5.Text = "Going On:";
            // 
            // goingOnTextBox
            // 
            goingOnTextBox.Location = new Point(257, 94);
            goingOnTextBox.Name = "goingOnTextBox";
            goingOnTextBox.Size = new Size(201, 30);
            goingOnTextBox.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 65);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 45;
            label6.Text = "Source:";
            // 
            // sourceTextBox
            // 
            sourceTextBox.Location = new Point(483, 91);
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.Size = new Size(201, 30);
            sourceTextBox.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(779, 65);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 47;
            label7.Text = "Notes:";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(695, 91);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(237, 30);
            noteTextBox.TabIndex = 46;
            // 
            // removeButton
            // 
            removeButton.FlatAppearance.BorderSize = 2;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Location = new Point(528, 585);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(201, 65);
            removeButton.TabIndex = 48;
            removeButton.Text = "Remove Selected\r\nFrom Order List:";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // markOrderedButton
            // 
            markOrderedButton.FlatAppearance.BorderSize = 2;
            markOrderedButton.FlatStyle = FlatStyle.Flat;
            markOrderedButton.Location = new Point(61, 585);
            markOrderedButton.Name = "markOrderedButton";
            markOrderedButton.Size = new Size(201, 65);
            markOrderedButton.TabIndex = 49;
            markOrderedButton.Text = "Mark Selected\r\nAs Ordered:";
            markOrderedButton.UseVisualStyleBackColor = true;
            markOrderedButton.Click += markOrderedButton_Click;
            // 
            // markInStockButton
            // 
            markInStockButton.FlatAppearance.BorderSize = 2;
            markInStockButton.FlatStyle = FlatStyle.Flat;
            markInStockButton.Location = new Point(292, 585);
            markInStockButton.Name = "markInStockButton";
            markInStockButton.Size = new Size(201, 65);
            markInStockButton.TabIndex = 50;
            markInStockButton.Text = "Mark Selected\r\nAs In Stock:";
            markInStockButton.UseVisualStyleBackColor = true;
            markInStockButton.Click += markInStockButton_Click;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 2;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(887, 600);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(250, 35);
            closeButton.TabIndex = 51;
            closeButton.Text = "Return to Home Page:";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // PartsOrderForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1172, 672);
            Controls.Add(closeButton);
            Controls.Add(markInStockButton);
            Controls.Add(markOrderedButton);
            Controls.Add(removeButton);
            Controls.Add(label7);
            Controls.Add(noteTextBox);
            Controls.Add(label6);
            Controls.Add(sourceTextBox);
            Controls.Add(label5);
            Controls.Add(goingOnTextBox);
            Controls.Add(label3);
            Controls.Add(partTextBox);
            Controls.Add(addToOrderButton);
            Controls.Add(label4);
            Controls.Add(ordersOutListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PartsOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Max-Cantrell-CPT-185-Final-Poject";
            Load += PartsOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox ordersOutListBox;
        private Label label4;
        private Button addToOrderButton;
        private TextBox partTextBox;
        private Label label3;
        private Label label5;
        private TextBox goingOnTextBox;
        private Label label6;
        private TextBox sourceTextBox;
        private Label label7;
        private TextBox noteTextBox;
        private Button removeButton;
        private Button markOrderedButton;
        private Button markInStockButton;
        private Button closeButton;
    }
}
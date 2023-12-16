namespace B_A_Software
{
    partial class SplitBillView
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
            PrintBtn = new Button();
            OrderListBox = new ListBox();
            PayListBox = new ListBox();
            SplitPayBtn = new Button();
            OrderLab = new Label();
            PayLab = new Label();
            AmountLab = new Label();
            TipLab = new Label();
            TipTxtBox = new TextBox();
            AmountTxtBox = new TextBox();
            PayedLab = new Label();
            PayedTxtBox = new TextBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // PrintBtn
            // 
            PrintBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.Location = new Point(659, 337);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(129, 101);
            PrintBtn.TabIndex = 0;
            PrintBtn.Text = "Drucken";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // OrderListBox
            // 
            OrderListBox.FormattingEnabled = true;
            OrderListBox.ItemHeight = 15;
            OrderListBox.Location = new Point(38, 83);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(235, 334);
            OrderListBox.TabIndex = 1;
            OrderListBox.SelectedIndexChanged += OrderListBox_SelectedIndexChanged;
            // 
            // PayListBox
            // 
            PayListBox.FormattingEnabled = true;
            PayListBox.ItemHeight = 15;
            PayListBox.Location = new Point(296, 79);
            PayListBox.Name = "PayListBox";
            PayListBox.Size = new Size(235, 334);
            PayListBox.TabIndex = 2;
            PayListBox.SelectedIndexChanged += PayListBox_SelectedIndexChanged;
            // 
            // SplitPayBtn
            // 
            SplitPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SplitPayBtn.Location = new Point(659, 220);
            SplitPayBtn.Name = "SplitPayBtn";
            SplitPayBtn.Size = new Size(129, 101);
            SplitPayBtn.TabIndex = 3;
            SplitPayBtn.Text = "Bezahlen";
            SplitPayBtn.UseVisualStyleBackColor = true;
            // 
            // OrderLab
            // 
            OrderLab.AutoSize = true;
            OrderLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLab.Location = new Point(38, 48);
            OrderLab.Name = "OrderLab";
            OrderLab.Size = new Size(75, 28);
            OrderLab.TabIndex = 4;
            OrderLab.Text = "Bestellt";
            OrderLab.Click += OrderLab_Click;
            // 
            // PayLab
            // 
            PayLab.AutoSize = true;
            PayLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayLab.Location = new Point(296, 48);
            PayLab.Name = "PayLab";
            PayLab.Size = new Size(106, 28);
            PayLab.TabIndex = 5;
            PayLab.Text = "Abrechnen";
            PayLab.Click += PayLab_Click;
            // 
            // AmountLab
            // 
            AmountLab.AutoSize = true;
            AmountLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLab.Location = new Point(554, 57);
            AmountLab.Name = "AmountLab";
            AmountLab.Size = new Size(69, 28);
            AmountLab.TabIndex = 6;
            AmountLab.Text = "Betrag";
            // 
            // TipLab
            // 
            TipLab.AutoSize = true;
            TipLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TipLab.Location = new Point(554, 97);
            TipLab.Name = "TipLab";
            TipLab.Size = new Size(92, 28);
            TipLab.TabIndex = 7;
            TipLab.Text = "Trinkgeld";
            // 
            // TipTxtBox
            // 
            TipTxtBox.Location = new Point(659, 102);
            TipTxtBox.Name = "TipTxtBox";
            TipTxtBox.Size = new Size(129, 23);
            TipTxtBox.TabIndex = 9;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(659, 62);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(129, 23);
            AmountTxtBox.TabIndex = 8;
            AmountTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // PayedLab
            // 
            PayedLab.AutoSize = true;
            PayedLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayedLab.Location = new Point(554, 137);
            PayedLab.Name = "PayedLab";
            PayedLab.Size = new Size(91, 28);
            PayedLab.TabIndex = 10;
            PayedLab.Text = "Gegeben";
            // 
            // PayedTxtBox
            // 
            PayedTxtBox.Location = new Point(659, 145);
            PayedTxtBox.Name = "PayedTxtBox";
            PayedTxtBox.Size = new Size(129, 23);
            PayedTxtBox.TabIndex = 11;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SplitBillView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(PayedTxtBox);
            Controls.Add(PayedLab);
            Controls.Add(TipTxtBox);
            Controls.Add(AmountTxtBox);
            Controls.Add(TipLab);
            Controls.Add(AmountLab);
            Controls.Add(PayLab);
            Controls.Add(OrderLab);
            Controls.Add(SplitPayBtn);
            Controls.Add(PayListBox);
            Controls.Add(OrderListBox);
            Controls.Add(PrintBtn);
            Name = "SplitBillView";
            Text = "Getrennt zahlen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrintBtn;
        private ListBox OrderListBox;
        private ListBox PayListBox;
        private Button SplitPayBtn;
        private Label OrderLab;
        private Label PayLab;
        private Label AmountLab;
        private Label TipLab;
        private TextBox textBox1;
        private TextBox TipTxtBox;
        private TextBox AmountTxtBox;
        private Label PayedLab;
        private TextBox PayedTxtBox;
        private Button BackBtn;
    }
}
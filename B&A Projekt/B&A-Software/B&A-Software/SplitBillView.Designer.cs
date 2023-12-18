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
            PrintBtn.Location = new Point(753, 449);
            PrintBtn.Margin = new Padding(4, 4, 4, 4);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(148, 134);
            PrintBtn.TabIndex = 0;
            PrintBtn.Text = "Drucken";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // OrderListBox
            // 
            OrderListBox.FormattingEnabled = true;
            OrderListBox.ItemHeight = 20;
            OrderListBox.Location = new Point(44, 111);
            OrderListBox.Margin = new Padding(4, 4, 4, 4);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(268, 444);
            OrderListBox.TabIndex = 1;
            OrderListBox.SelectedIndexChanged += OrderListBox_SelectedIndexChanged;
            // 
            // PayListBox
            // 
            PayListBox.FormattingEnabled = true;
            PayListBox.ItemHeight = 20;
            PayListBox.Location = new Point(338, 106);
            PayListBox.Margin = new Padding(4, 4, 4, 4);
            PayListBox.Name = "PayListBox";
            PayListBox.Size = new Size(268, 444);
            PayListBox.TabIndex = 2;
            PayListBox.SelectedIndexChanged += PayListBox_SelectedIndexChanged;
            // 
            // SplitPayBtn
            // 
            SplitPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SplitPayBtn.Location = new Point(753, 293);
            SplitPayBtn.Margin = new Padding(4, 4, 4, 4);
            SplitPayBtn.Name = "SplitPayBtn";
            SplitPayBtn.Size = new Size(148, 134);
            SplitPayBtn.TabIndex = 3;
            SplitPayBtn.Text = "Bezahlen";
            SplitPayBtn.UseVisualStyleBackColor = true;
            SplitPayBtn.Click += SplitPayBtn_Click;
            // 
            // OrderLab
            // 
            OrderLab.AutoSize = true;
            OrderLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLab.Location = new Point(44, 64);
            OrderLab.Margin = new Padding(4, 0, 4, 0);
            OrderLab.Name = "OrderLab";
            OrderLab.Size = new Size(94, 35);
            OrderLab.TabIndex = 4;
            OrderLab.Text = "Bestellt";
            // 
            // PayLab
            // 
            PayLab.AutoSize = true;
            PayLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayLab.Location = new Point(338, 64);
            PayLab.Margin = new Padding(4, 0, 4, 0);
            PayLab.Name = "PayLab";
            PayLab.Size = new Size(135, 35);
            PayLab.TabIndex = 5;
            PayLab.Text = "Abrechnen";
            // 
            // AmountLab
            // 
            AmountLab.AutoSize = true;
            AmountLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLab.Location = new Point(633, 76);
            AmountLab.Margin = new Padding(4, 0, 4, 0);
            AmountLab.Name = "AmountLab";
            AmountLab.Size = new Size(87, 35);
            AmountLab.TabIndex = 6;
            AmountLab.Text = "Betrag";
            // 
            // TipLab
            // 
            TipLab.AutoSize = true;
            TipLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TipLab.Location = new Point(633, 164);
            TipLab.Margin = new Padding(4, 0, 4, 0);
            TipLab.Name = "TipLab";
            TipLab.Size = new Size(116, 35);
            TipLab.TabIndex = 7;
            TipLab.Text = "Trinkgeld";
            // 
            // TipTxtBox
            // 
            TipTxtBox.Location = new Point(753, 171);
            TipTxtBox.Margin = new Padding(4, 4, 4, 4);
            TipTxtBox.Name = "TipTxtBox";
            TipTxtBox.Size = new Size(147, 27);
            TipTxtBox.TabIndex = 9;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(753, 82);
            AmountTxtBox.Margin = new Padding(4, 4, 4, 4);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(147, 27);
            AmountTxtBox.TabIndex = 8;
            // 
            // PayedLab
            // 
            PayedLab.AutoSize = true;
            PayedLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayedLab.Location = new Point(633, 115);
            PayedLab.Margin = new Padding(4, 0, 4, 0);
            PayedLab.Name = "PayedLab";
            PayedLab.Size = new Size(115, 35);
            PayedLab.TabIndex = 10;
            PayedLab.Text = "Gegeben";
            // 
            // PayedTxtBox
            // 
            PayedTxtBox.Location = new Point(753, 126);
            PayedTxtBox.Margin = new Padding(4, 4, 4, 4);
            PayedTxtBox.Name = "PayedTxtBox";
            PayedTxtBox.Size = new Size(147, 27);
            PayedTxtBox.TabIndex = 11;
            PayedTxtBox.TextChanged += PayedTxtBox_TextChanged;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(14, 16);
            BackBtn.Margin = new Padding(4, 4, 4, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 31);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SplitBillView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(4, 4, 4, 4);
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
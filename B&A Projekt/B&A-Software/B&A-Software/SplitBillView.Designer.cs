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
            PrintBtn.Location = new Point(1224, 719);
            PrintBtn.Margin = new Padding(6);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(240, 215);
            PrintBtn.TabIndex = 0;
            PrintBtn.Text = "Drucken";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // OrderListBox
            // 
            OrderListBox.FormattingEnabled = true;
            OrderListBox.ItemHeight = 32;
            OrderListBox.Location = new Point(71, 177);
            OrderListBox.Margin = new Padding(6);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(433, 708);
            OrderListBox.TabIndex = 1;
            OrderListBox.SelectedIndexChanged += OrderListBox_SelectedIndexChanged;
            // 
            // PayListBox
            // 
            PayListBox.FormattingEnabled = true;
            PayListBox.ItemHeight = 32;
            PayListBox.Location = new Point(550, 169);
            PayListBox.Margin = new Padding(6);
            PayListBox.Name = "PayListBox";
            PayListBox.Size = new Size(433, 708);
            PayListBox.TabIndex = 2;
            PayListBox.SelectedIndexChanged += PayListBox_SelectedIndexChanged;
            // 
            // SplitPayBtn
            // 
            SplitPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SplitPayBtn.Location = new Point(1224, 469);
            SplitPayBtn.Margin = new Padding(6);
            SplitPayBtn.Name = "SplitPayBtn";
            SplitPayBtn.Size = new Size(240, 215);
            SplitPayBtn.TabIndex = 3;
            SplitPayBtn.Text = "Bezahlen";
            SplitPayBtn.UseVisualStyleBackColor = true;
            SplitPayBtn.Click += SplitPayBtn_Click;
            // 
            // OrderLab
            // 
            OrderLab.AutoSize = true;
            OrderLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLab.Location = new Point(71, 102);
            OrderLab.Margin = new Padding(6, 0, 6, 0);
            OrderLab.Name = "OrderLab";
            OrderLab.Size = new Size(153, 54);
            OrderLab.TabIndex = 4;
            OrderLab.Text = "Bestellt";
            // 
            // PayLab
            // 
            PayLab.AutoSize = true;
            PayLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayLab.Location = new Point(550, 102);
            PayLab.Margin = new Padding(6, 0, 6, 0);
            PayLab.Name = "PayLab";
            PayLab.Size = new Size(216, 54);
            PayLab.TabIndex = 5;
            PayLab.Text = "Abrechnen";
            // 
            // AmountLab
            // 
            AmountLab.AutoSize = true;
            AmountLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLab.Location = new Point(1029, 122);
            AmountLab.Margin = new Padding(6, 0, 6, 0);
            AmountLab.Name = "AmountLab";
            AmountLab.Size = new Size(139, 54);
            AmountLab.TabIndex = 6;
            AmountLab.Text = "Betrag";
            // 
            // TipLab
            // 
            TipLab.AutoSize = true;
            TipLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TipLab.Location = new Point(1029, 263);
            TipLab.Margin = new Padding(6, 0, 6, 0);
            TipLab.Name = "TipLab";
            TipLab.Size = new Size(187, 54);
            TipLab.TabIndex = 7;
            TipLab.Text = "Trinkgeld";
            // 
            // TipTxtBox
            // 
            TipTxtBox.Location = new Point(1224, 274);
            TipTxtBox.Margin = new Padding(6);
            TipTxtBox.Name = "TipTxtBox";
            TipTxtBox.Size = new Size(236, 39);
            TipTxtBox.TabIndex = 9;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(1224, 132);
            AmountTxtBox.Margin = new Padding(6);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(236, 39);
            AmountTxtBox.TabIndex = 8;
            // 
            // PayedLab
            // 
            PayedLab.AutoSize = true;
            PayedLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayedLab.Location = new Point(1029, 184);
            PayedLab.Margin = new Padding(6, 0, 6, 0);
            PayedLab.Name = "PayedLab";
            PayedLab.Size = new Size(184, 54);
            PayedLab.TabIndex = 10;
            PayedLab.Text = "Gegeben";
            // 
            // PayedTxtBox
            // 
            PayedTxtBox.Location = new Point(1224, 201);
            PayedTxtBox.Margin = new Padding(6);
            PayedTxtBox.Name = "PayedTxtBox";
            PayedTxtBox.Size = new Size(236, 39);
            PayedTxtBox.TabIndex = 11;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(22, 26);
            BackBtn.Margin = new Padding(6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(139, 49);
            BackBtn.TabIndex = 12;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SplitBillView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
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
            Margin = new Padding(6);
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
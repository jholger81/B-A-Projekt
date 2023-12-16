namespace B_A_Software
{
    partial class TogetherBillView
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
            PayedTxtBox = new TextBox();
            PayedLab = new Label();
            TipTxtBox = new TextBox();
            AmountTxtBox = new TextBox();
            TipLab = new Label();
            AmountLab = new Label();
            OrderLab = new Label();
            SplitPayBtn = new Button();
            listBox1 = new ListBox();
            PrintBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // PayedTxtBox
            // 
            PayedTxtBox.Location = new Point(646, 142);
            PayedTxtBox.Name = "PayedTxtBox";
            PayedTxtBox.Size = new Size(129, 23);
            PayedTxtBox.TabIndex = 21;
            // 
            // PayedLab
            // 
            PayedLab.AutoSize = true;
            PayedLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayedLab.Location = new Point(541, 134);
            PayedLab.Name = "PayedLab";
            PayedLab.Size = new Size(91, 28);
            PayedLab.TabIndex = 20;
            PayedLab.Text = "Gegeben";
            // 
            // TipTxtBox
            // 
            TipTxtBox.Location = new Point(646, 99);
            TipTxtBox.Name = "TipTxtBox";
            TipTxtBox.Size = new Size(129, 23);
            TipTxtBox.TabIndex = 19;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(646, 59);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(129, 23);
            AmountTxtBox.TabIndex = 18;
            // 
            // TipLab
            // 
            TipLab.AutoSize = true;
            TipLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TipLab.Location = new Point(541, 94);
            TipLab.Name = "TipLab";
            TipLab.Size = new Size(92, 28);
            TipLab.TabIndex = 17;
            TipLab.Text = "Trinkgeld";
            // 
            // AmountLab
            // 
            AmountLab.AutoSize = true;
            AmountLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLab.Location = new Point(541, 54);
            AmountLab.Name = "AmountLab";
            AmountLab.Size = new Size(69, 28);
            AmountLab.TabIndex = 16;
            AmountLab.Text = "Betrag";
            // 
            // OrderLab
            // 
            OrderLab.AutoSize = true;
            OrderLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLab.Location = new Point(25, 49);
            OrderLab.Name = "OrderLab";
            OrderLab.Size = new Size(75, 28);
            OrderLab.TabIndex = 15;
            OrderLab.Text = "Bestellt";
            OrderLab.Click += OrderLab_Click;
            // 
            // SplitPayBtn
            // 
            SplitPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SplitPayBtn.Location = new Point(646, 217);
            SplitPayBtn.Name = "SplitPayBtn";
            SplitPayBtn.Size = new Size(129, 101);
            SplitPayBtn.TabIndex = 14;
            SplitPayBtn.Text = "Bezahlen";
            SplitPayBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(25, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 349);
            listBox1.TabIndex = 13;
            // 
            // PrintBtn
            // 
            PrintBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.Location = new Point(646, 334);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(129, 101);
            PrintBtn.TabIndex = 12;
            PrintBtn.Text = "Drucken";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 22;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // TogetherBillView
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
            Controls.Add(OrderLab);
            Controls.Add(SplitPayBtn);
            Controls.Add(listBox1);
            Controls.Add(PrintBtn);
            Name = "TogetherBillView";
            Text = "Zusammen zahlen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PayedTxtBox;
        private Label PayedLab;
        private TextBox TipTxtBox;
        private TextBox AmountTxtBox;
        private Label TipLab;
        private Label AmountLab;
        private Label OrderLab;
        private Button SplitPayBtn;
        private ListBox listBox1;
        private Button PrintBtn;
        private Button BackBtn;
    }
}
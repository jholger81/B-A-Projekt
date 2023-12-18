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
            PayedTxtBox.Location = new Point(738, 123);
            PayedTxtBox.Margin = new Padding(3, 4, 3, 4);
            PayedTxtBox.Name = "PayedTxtBox";
            PayedTxtBox.Size = new Size(147, 27);
            PayedTxtBox.TabIndex = 21;
            PayedTxtBox.TextChanged += PayedTxtBox_TextChanged;
            // 
            // PayedLab
            // 
            PayedLab.AutoSize = true;
            PayedLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PayedLab.Location = new Point(618, 113);
            PayedLab.Name = "PayedLab";
            PayedLab.Size = new Size(115, 35);
            PayedLab.TabIndex = 20;
            PayedLab.Text = "Gegeben";
            // 
            // TipTxtBox
            // 
            TipTxtBox.Location = new Point(738, 165);
            TipTxtBox.Margin = new Padding(3, 4, 3, 4);
            TipTxtBox.Name = "TipTxtBox";
            TipTxtBox.Size = new Size(147, 27);
            TipTxtBox.TabIndex = 19;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(738, 79);
            AmountTxtBox.Margin = new Padding(3, 4, 3, 4);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(147, 27);
            AmountTxtBox.TabIndex = 18;
            // 
            // TipLab
            // 
            TipLab.AutoSize = true;
            TipLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TipLab.Location = new Point(618, 158);
            TipLab.Name = "TipLab";
            TipLab.Size = new Size(116, 35);
            TipLab.TabIndex = 17;
            TipLab.Text = "Trinkgeld";
            // 
            // AmountLab
            // 
            AmountLab.AutoSize = true;
            AmountLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLab.Location = new Point(618, 72);
            AmountLab.Name = "AmountLab";
            AmountLab.Size = new Size(87, 35);
            AmountLab.TabIndex = 16;
            AmountLab.Text = "Betrag";
            // 
            // OrderLab
            // 
            OrderLab.AutoSize = true;
            OrderLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLab.Location = new Point(29, 65);
            OrderLab.Name = "OrderLab";
            OrderLab.Size = new Size(94, 35);
            OrderLab.TabIndex = 15;
            OrderLab.Text = "Bestellt";
            // 
            // SplitPayBtn
            // 
            SplitPayBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SplitPayBtn.Location = new Point(738, 289);
            SplitPayBtn.Margin = new Padding(3, 4, 3, 4);
            SplitPayBtn.Name = "SplitPayBtn";
            SplitPayBtn.Size = new Size(147, 135);
            SplitPayBtn.TabIndex = 14;
            SplitPayBtn.Text = "Bezahlen";
            SplitPayBtn.UseVisualStyleBackColor = true;
            SplitPayBtn.Click += SplitPayBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(29, 107);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(571, 464);
            listBox1.TabIndex = 13;
            // 
            // PrintBtn
            // 
            PrintBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrintBtn.Location = new Point(738, 445);
            PrintBtn.Margin = new Padding(3, 4, 3, 4);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(147, 135);
            PrintBtn.TabIndex = 12;
            PrintBtn.Text = "Drucken";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(14, 16);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 31);
            BackBtn.TabIndex = 22;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // TogetherBillView
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
            Controls.Add(OrderLab);
            Controls.Add(SplitPayBtn);
            Controls.Add(listBox1);
            Controls.Add(PrintBtn);
            Margin = new Padding(3, 4, 3, 4);
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
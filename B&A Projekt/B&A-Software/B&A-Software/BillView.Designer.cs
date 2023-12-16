namespace B_A_Software
{
    partial class BillView
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
            TogetherBillBtn = new Button();
            SplitBillBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // TogetherBillBtn
            // 
            TogetherBillBtn.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            TogetherBillBtn.Location = new Point(9, 33);
            TogetherBillBtn.Name = "TogetherBillBtn";
            TogetherBillBtn.Size = new Size(394, 405);
            TogetherBillBtn.TabIndex = 0;
            TogetherBillBtn.Text = "Zusammen zahlen";
            TogetherBillBtn.UseVisualStyleBackColor = true;
            TogetherBillBtn.Click += TogetherBillBtn_Click;
            // 
            // SplitBillBtn
            // 
            SplitBillBtn.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            SplitBillBtn.Location = new Point(409, 33);
            SplitBillBtn.Name = "SplitBillBtn";
            SplitBillBtn.Size = new Size(388, 405);
            SplitBillBtn.TabIndex = 1;
            SplitBillBtn.Text = "Getrennt zahlen";
            SplitBillBtn.UseVisualStyleBackColor = true;
            SplitBillBtn.Click += SplitBillBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // BillView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(SplitBillBtn);
            Controls.Add(TogetherBillBtn);
            Name = "BillView";
            Text = "Abrechnen";
            ResumeLayout(false);
        }

        #endregion

        private Button TogetherBillBtn;
        private Button SplitBillBtn;
        private Button BackBtn;
    }
}
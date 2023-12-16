namespace B_A_Software
{
    partial class TableSelect
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
            BackBtn = new Button();
            TableBtn1 = new Button();
            TableBtn3 = new Button();
            TableBtn4 = new Button();
            TableBtn2 = new Button();
            TableBtn5 = new Button();
            AreaNumLab = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(25, 17);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // TableBtn1
            // 
            TableBtn1.BackColor = SystemColors.Highlight;
            TableBtn1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableBtn1.Location = new Point(148, 59);
            TableBtn1.MinimumSize = new Size(100, 100);
            TableBtn1.Name = "TableBtn1";
            TableBtn1.Size = new Size(100, 100);
            TableBtn1.TabIndex = 1;
            TableBtn1.Text = "Tisch ";
            TableBtn1.UseVisualStyleBackColor = false;
            TableBtn1.Click += TableBtn1_Click;
            // 
            // TableBtn3
            // 
            TableBtn3.BackColor = SystemColors.Highlight;
            TableBtn3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableBtn3.Location = new Point(295, 167);
            TableBtn3.MinimumSize = new Size(100, 100);
            TableBtn3.Name = "TableBtn3";
            TableBtn3.Size = new Size(100, 100);
            TableBtn3.TabIndex = 2;
            TableBtn3.Text = "Tisch ";
            TableBtn3.UseVisualStyleBackColor = false;
            TableBtn3.Click += TableBtn3_Click;
            // 
            // TableBtn4
            // 
            TableBtn4.BackColor = SystemColors.Highlight;
            TableBtn4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableBtn4.Location = new Point(148, 293);
            TableBtn4.MinimumSize = new Size(100, 100);
            TableBtn4.Name = "TableBtn4";
            TableBtn4.Size = new Size(100, 100);
            TableBtn4.TabIndex = 3;
            TableBtn4.Text = "Tisch ";
            TableBtn4.UseVisualStyleBackColor = false;
            TableBtn4.Click += TableBtn4_Click;
            // 
            // TableBtn2
            // 
            TableBtn2.BackColor = SystemColors.Highlight;
            TableBtn2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableBtn2.Location = new Point(435, 59);
            TableBtn2.MinimumSize = new Size(100, 100);
            TableBtn2.Name = "TableBtn2";
            TableBtn2.Size = new Size(100, 100);
            TableBtn2.TabIndex = 4;
            TableBtn2.Text = "Tisch ";
            TableBtn2.UseVisualStyleBackColor = false;
            TableBtn2.Click += TableBtn2_Click;
            // 
            // TableBtn5
            // 
            TableBtn5.BackColor = SystemColors.Highlight;
            TableBtn5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableBtn5.Location = new Point(435, 293);
            TableBtn5.MinimumSize = new Size(100, 100);
            TableBtn5.Name = "TableBtn5";
            TableBtn5.Size = new Size(100, 100);
            TableBtn5.TabIndex = 5;
            TableBtn5.Text = "Tisch ";
            TableBtn5.UseVisualStyleBackColor = false;
            TableBtn5.Click += TableBtn5_Click;
            // 
            // AreaNumLab
            // 
            AreaNumLab.AutoSize = true;
            AreaNumLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AreaNumLab.Location = new Point(285, 17);
            AreaNumLab.Name = "AreaNumLab";
            AreaNumLab.Size = new Size(110, 28);
            AreaNumLab.TabIndex = 6;
            AreaNumLab.Text = "Bereich Nr.:";
            // 
            // TableSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 452);
            Controls.Add(AreaNumLab);
            Controls.Add(TableBtn5);
            Controls.Add(TableBtn2);
            Controls.Add(TableBtn4);
            Controls.Add(TableBtn3);
            Controls.Add(TableBtn1);
            Controls.Add(BackBtn);
            Name = "TableSelect";
            Text = "Tischauswahl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button TableBtn1;
        private Button TableBtn3;
        private Button TableBtn4;
        private Button TableBtn2;
        private Button TableBtn5;
        private Label AreaNumLab;
    }
}
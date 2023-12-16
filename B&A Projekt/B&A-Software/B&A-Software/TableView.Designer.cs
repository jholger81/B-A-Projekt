namespace B_A_Software
{
    partial class TableView
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
            OrderBtn = new Button();
            TableSwapBtn = new Button();
            BillBtn = new Button();
            EmptyTableBtn = new Button();
            TableLab = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderBtn.Location = new Point(24, 276);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(125, 125);
            OrderBtn.TabIndex = 2;
            OrderBtn.Text = "Bestellen";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // TableSwapBtn
            // 
            TableSwapBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableSwapBtn.Location = new Point(24, 81);
            TableSwapBtn.Name = "TableSwapBtn";
            TableSwapBtn.Size = new Size(125, 125);
            TableSwapBtn.TabIndex = 3;
            TableSwapBtn.Text = "Tisch wechseln";
            TableSwapBtn.UseVisualStyleBackColor = true;
            TableSwapBtn.Click += TableSwapBtn_Click;
            // 
            // BillBtn
            // 
            BillBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BillBtn.Location = new Point(203, 276);
            BillBtn.Name = "BillBtn";
            BillBtn.Size = new Size(125, 125);
            BillBtn.TabIndex = 4;
            BillBtn.Text = "Abrechnen";
            BillBtn.UseVisualStyleBackColor = true;
            BillBtn.Click += BillBtn_Click;
            // 
            // EmptyTableBtn
            // 
            EmptyTableBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmptyTableBtn.Location = new Point(203, 81);
            EmptyTableBtn.Name = "EmptyTableBtn";
            EmptyTableBtn.Size = new Size(125, 125);
            EmptyTableBtn.TabIndex = 5;
            EmptyTableBtn.Text = "Tisch leeren";
            EmptyTableBtn.UseVisualStyleBackColor = true;
            EmptyTableBtn.Click += EmptyTableBtn_Click;
            // 
            // TableLab
            // 
            TableLab.AutoSize = true;
            TableLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TableLab.Location = new Point(130, 28);
            TableLab.Name = "TableLab";
            TableLab.Size = new Size(90, 28);
            TableLab.TabIndex = 6;
            TableLab.Text = "Tisch Nr.:";
            // 
            // TableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 445);
            Controls.Add(TableLab);
            Controls.Add(EmptyTableBtn);
            Controls.Add(BillBtn);
            Controls.Add(TableSwapBtn);
            Controls.Add(OrderBtn);
            Controls.Add(BackBtn);
            Name = "TableView";
            Text = "Tisch Ansicht";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button OrderBtn;
        private Button TableSwapBtn;
        private Button BillBtn;
        private Button EmptyTableBtn;
        private Label TableLab;
    }
}
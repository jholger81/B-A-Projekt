using System.Data.OleDb;

namespace B_A_Software
{
    partial class OrderView
    {
        OleDbConnection connection = new OleDbConnection();
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
            FoodListBox = new ListBox();
            DrinksListBox = new ListBox();
            WKListBox = new ListBox();
            BackBtn = new Button();
            FoodLab = new Label();
            DrinkLab = new Label();
            WKLab = new Label();
            OrderBtn = new Button();
            tbExtras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // FoodListBox
            // 
            FoodListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FoodListBox.FormattingEnabled = true;
            FoodListBox.ItemHeight = 28;
            FoodListBox.Location = new Point(12, 89);
            FoodListBox.Name = "FoodListBox";
            FoodListBox.Size = new Size(233, 340);
            FoodListBox.TabIndex = 0;
            FoodListBox.SelectedIndexChanged += FoodListBox_SelectedIndexChanged;
            // 
            // DrinksListBox
            // 
            DrinksListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DrinksListBox.FormattingEnabled = true;
            DrinksListBox.ItemHeight = 28;
            DrinksListBox.Location = new Point(283, 89);
            DrinksListBox.Name = "DrinksListBox";
            DrinksListBox.Size = new Size(233, 340);
            DrinksListBox.TabIndex = 1;
            DrinksListBox.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // WKListBox
            // 
            WKListBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WKListBox.FormattingEnabled = true;
            WKListBox.ItemHeight = 28;
            WKListBox.Location = new Point(558, 89);
            WKListBox.Name = "WKListBox";
            WKListBox.Size = new Size(233, 340);
            WKListBox.TabIndex = 2;
            WKListBox.SelectedIndexChanged += WKListBox_SelectedIndexChanged;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Zurück";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // FoodLab
            // 
            FoodLab.AutoSize = true;
            FoodLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FoodLab.Location = new Point(12, 49);
            FoodLab.Name = "FoodLab";
            FoodLab.Size = new Size(79, 28);
            FoodLab.TabIndex = 4;
            FoodLab.Text = "Speisen";
            // 
            // DrinkLab
            // 
            DrinkLab.AutoSize = true;
            DrinkLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DrinkLab.Location = new Point(283, 49);
            DrinkLab.Name = "DrinkLab";
            DrinkLab.Size = new Size(91, 28);
            DrinkLab.TabIndex = 5;
            DrinkLab.Text = "Getränke";
            // 
            // WKLab
            // 
            WKLab.AutoSize = true;
            WKLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WKLab.Location = new Point(558, 49);
            WKLab.Name = "WKLab";
            WKLab.Size = new Size(109, 28);
            WKLab.TabIndex = 6;
            WKLab.Text = "Warenkorb";
            WKLab.Click += label2_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderBtn.Location = new Point(687, 433);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(104, 46);
            OrderBtn.TabIndex = 7;
            OrderBtn.Text = "Bestellen";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // tbExtras
            // 
            tbExtras.Location = new Point(374, 444);
            tbExtras.Name = "tbExtras";
            tbExtras.Size = new Size(250, 23);
            tbExtras.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 442);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 10;
            label1.Text = "Extras";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 485);
            Controls.Add(tbExtras);
            Controls.Add(label1);
            Controls.Add(OrderBtn);
            Controls.Add(WKLab);
            Controls.Add(DrinkLab);
            Controls.Add(FoodLab);
            Controls.Add(BackBtn);
            Controls.Add(WKListBox);
            Controls.Add(DrinksListBox);
            Controls.Add(FoodListBox);
            Name = "OrderView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox FoodListBox;
        private ListBox DrinksListBox;
        private ListBox WKListBox;
        private Button BackBtn;
        private Label FoodLab;
        private Label DrinkLab;
        private Label WKLab;
        private Button OrderBtn;
        private TextBox tbExtras;
        private Label label1;
    }
}
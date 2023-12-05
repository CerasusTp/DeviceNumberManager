namespace DeviceNumberManager
{
    partial class MainWindows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textRegisteredNumber = new TextBox();
            textNewNumber = new TextBox();
            label2 = new Label();
            ViewResultNumbers = new DataGridView();
            label3 = new Label();
            btnGenerateNumbers = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewResultNumbers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 0;
            label1.Text = "採番済";
            // 
            // textRegisteredNumber
            // 
            textRegisteredNumber.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            textRegisteredNumber.Location = new Point(120, 30);
            textRegisteredNumber.Name = "textRegisteredNumber";
            textRegisteredNumber.Size = new Size(150, 33);
            textRegisteredNumber.TabIndex = 1;
            // 
            // textNewNumber
            // 
            textNewNumber.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            textNewNumber.Location = new Point(120, 80);
            textNewNumber.Name = "textNewNumber";
            textNewNumber.Size = new Size(150, 33);
            textNewNumber.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 2;
            label2.Text = "新規数";
            // 
            // ViewResultNumbers
            // 
            ViewResultNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewResultNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewResultNumbers.Location = new Point(120, 190);
            ViewResultNumbers.Name = "ViewResultNumbers";
            ViewResultNumbers.ReadOnly = true;
            ViewResultNumbers.RowHeadersVisible = false;
            ViewResultNumbers.Size = new Size(150, 250);
            ViewResultNumbers.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(20, 298);
            label3.Name = "label3";
            label3.Size = new Size(55, 30);
            label3.TabIndex = 5;
            label3.Text = "結果";
            // 
            // btnGenerateNumbers
            // 
            btnGenerateNumbers.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnGenerateNumbers.Location = new Point(120, 130);
            btnGenerateNumbers.Name = "btnGenerateNumbers";
            btnGenerateNumbers.Size = new Size(150, 40);
            btnGenerateNumbers.TabIndex = 6;
            btnGenerateNumbers.Text = "採番";
            btnGenerateNumbers.UseVisualStyleBackColor = true;
            btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(304, 461);
            Controls.Add(btnGenerateNumbers);
            Controls.Add(label3);
            Controls.Add(ViewResultNumbers);
            Controls.Add(textNewNumber);
            Controls.Add(label2);
            Controls.Add(textRegisteredNumber);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "MainWindows";
            Text = "デバイス管理番号 採番くん";
            ((System.ComponentModel.ISupportInitialize)ViewResultNumbers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textRegisteredNumber;
        private TextBox textNewNumber;
        private Label label2;
        private DataGridView ViewResultNumbers;
        private Label label3;
        private Button btnGenerateNumbers;
    }
}

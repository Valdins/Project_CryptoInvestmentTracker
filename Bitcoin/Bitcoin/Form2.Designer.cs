namespace Bitcoin
{
    partial class Form2
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
            this.purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountBoughtTextBox = new System.Windows.Forms.TextBox();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.pricePerCoinTextBox = new System.Windows.Forms.TextBox();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.amountBoughtLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.pricePerCoinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // purchaseDateTimePicker
            // 
            this.purchaseDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchaseDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.purchaseDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.purchaseDateTimePicker.Location = new System.Drawing.Point(176, 97);
            this.purchaseDateTimePicker.Name = "purchaseDateTimePicker";
            this.purchaseDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.purchaseDateTimePicker.TabIndex = 5;
            // 
            // amountBoughtTextBox
            // 
            this.amountBoughtTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.amountBoughtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBoughtTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountBoughtTextBox.ForeColor = System.Drawing.Color.White;
            this.amountBoughtTextBox.Location = new System.Drawing.Point(276, 141);
            this.amountBoughtTextBox.Name = "amountBoughtTextBox";
            this.amountBoughtTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountBoughtTextBox.TabIndex = 1;
            // 
            // feeTextBox
            // 
            this.feeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.feeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeTextBox.ForeColor = System.Drawing.Color.White;
            this.feeTextBox.Location = new System.Drawing.Point(276, 182);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(100, 20);
            this.feeTextBox.TabIndex = 2;
            // 
            // pricePerCoinTextBox
            // 
            this.pricePerCoinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pricePerCoinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricePerCoinTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricePerCoinTextBox.ForeColor = System.Drawing.Color.White;
            this.pricePerCoinTextBox.Location = new System.Drawing.Point(276, 222);
            this.pricePerCoinTextBox.Name = "pricePerCoinTextBox";
            this.pricePerCoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerCoinTextBox.TabIndex = 3;
            // 
            // insertDataButton
            // 
            this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertDataButton.Location = new System.Drawing.Point(216, 264);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(131, 34);
            this.insertDataButton.TabIndex = 4;
            this.insertDataButton.Text = "Insert";
            this.insertDataButton.UseVisualStyleBackColor = true;
            this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
            // 
            // amountBoughtLabel
            // 
            this.amountBoughtLabel.AutoSize = true;
            this.amountBoughtLabel.ForeColor = System.Drawing.Color.White;
            this.amountBoughtLabel.Location = new System.Drawing.Point(172, 144);
            this.amountBoughtLabel.Name = "amountBoughtLabel";
            this.amountBoughtLabel.Size = new System.Drawing.Size(98, 15);
            this.amountBoughtLabel.TabIndex = 6;
            this.amountBoughtLabel.Text = "Amount Invested";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(245, 185);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(25, 15);
            this.feeLabel.TabIndex = 7;
            this.feeLabel.Text = "Fee";
            // 
            // pricePerCoinLabel
            // 
            this.pricePerCoinLabel.AutoSize = true;
            this.pricePerCoinLabel.Location = new System.Drawing.Point(191, 225);
            this.pricePerCoinLabel.Name = "pricePerCoinLabel";
            this.pricePerCoinLabel.Size = new System.Drawing.Size(79, 15);
            this.pricePerCoinLabel.TabIndex = 8;
            this.pricePerCoinLabel.Text = "Price per coin";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.pricePerCoinLabel);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountBoughtLabel);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.pricePerCoinTextBox);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.amountBoughtTextBox);
            this.Controls.Add(this.purchaseDateTimePicker);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker purchaseDateTimePicker;
        private System.Windows.Forms.TextBox amountBoughtTextBox;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.TextBox pricePerCoinTextBox;
        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Label amountBoughtLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label pricePerCoinLabel;
    }
}
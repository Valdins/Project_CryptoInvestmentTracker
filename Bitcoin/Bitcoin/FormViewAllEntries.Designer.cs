namespace Bitcoin
{
    partial class FormViewAllEntries
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
            this.listViewAllEntries = new System.Windows.Forms.ListView();
            this.columnPurchaseDate = new System.Windows.Forms.ColumnHeader();
            this.columnAmountBought = new System.Windows.Forms.ColumnHeader();
            this.columnFeePaid = new System.Windows.Forms.ColumnHeader();
            this.columnPricePerCoin = new System.Windows.Forms.ColumnHeader();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllEntries
            // 
            this.listViewAllEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.listViewAllEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPurchaseDate,
            this.columnAmountBought,
            this.columnFeePaid,
            this.columnPricePerCoin});
            this.listViewAllEntries.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewAllEntries.ForeColor = System.Drawing.Color.White;
            this.listViewAllEntries.HideSelection = false;
            this.listViewAllEntries.Location = new System.Drawing.Point(47, 48);
            this.listViewAllEntries.Name = "listViewAllEntries";
            this.listViewAllEntries.Size = new System.Drawing.Size(444, 275);
            this.listViewAllEntries.TabIndex = 0;
            this.listViewAllEntries.UseCompatibleStateImageBehavior = false;
            this.listViewAllEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnPurchaseDate
            // 
            this.columnPurchaseDate.Text = "Purchase Date";
            this.columnPurchaseDate.Width = 120;
            // 
            // columnAmountBought
            // 
            this.columnAmountBought.Text = "Amount Bought";
            this.columnAmountBought.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAmountBought.Width = 130;
            // 
            // columnFeePaid
            // 
            this.columnFeePaid.Text = "Fee";
            this.columnFeePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnPricePerCoin
            // 
            this.columnPricePerCoin.Text = "Price per Coin";
            this.columnPricePerCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPricePerCoin.Width = 120;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(47, 342);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(117, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove entry";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // FormViewAllEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listViewAllEntries);
            this.Name = "FormViewAllEntries";
            this.Text = "FormViewAllEntries";
            this.Load += new System.EventHandler(this.FormViewAllEntries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllEntries;
        private System.Windows.Forms.ColumnHeader columnPurchaseDate;
        private System.Windows.Forms.ColumnHeader columnAmountBought;
        private System.Windows.Forms.ColumnHeader columnFeePaid;
        private System.Windows.Forms.ColumnHeader columnPricePerCoin;
        private System.Windows.Forms.Button removeButton;
    }
}
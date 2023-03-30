namespace Bitcoin
{
    partial class mainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPanel));
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.viewListButton = new System.Windows.Forms.Button();
            this.insertMenubutton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BTCpriceDisplayLabel = new System.Windows.Forms.Label();
            this.PortfolioBalancePanel = new System.Windows.Forms.Panel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceValueLabel = new System.Windows.Forms.Label();
            this.ProfitPanel = new System.Windows.Forms.Panel();
            this.profitLabel = new System.Windows.Forms.Label();
            this.profitValueLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.chooseCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.maximiseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenuPanel.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PortfolioBalancePanel.SuspendLayout();
            this.ProfitPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sideMenuPanel.Controls.Add(this.viewListButton);
            this.sideMenuPanel.Controls.Add(this.insertMenubutton);
            this.sideMenuPanel.Controls.Add(this.homeMenuButton);
            this.sideMenuPanel.Controls.Add(this.panel2);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 41);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(198, 550);
            this.sideMenuPanel.TabIndex = 8;
            // 
            // viewListButton
            // 
            this.viewListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewListButton.ForeColor = System.Drawing.Color.White;
            this.viewListButton.Location = new System.Drawing.Point(0, 193);
            this.viewListButton.Name = "viewListButton";
            this.viewListButton.Size = new System.Drawing.Size(198, 58);
            this.viewListButton.TabIndex = 10;
            this.viewListButton.Text = "All Entries";
            this.viewListButton.UseVisualStyleBackColor = true;
            this.viewListButton.Click += new System.EventHandler(this.viewListButton_Click);
            // 
            // insertMenubutton
            // 
            this.insertMenubutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.insertMenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertMenubutton.ForeColor = System.Drawing.Color.White;
            this.insertMenubutton.Location = new System.Drawing.Point(0, 135);
            this.insertMenubutton.Name = "insertMenubutton";
            this.insertMenubutton.Size = new System.Drawing.Size(198, 58);
            this.insertMenubutton.TabIndex = 9;
            this.insertMenubutton.Text = "Insert Data";
            this.insertMenubutton.UseVisualStyleBackColor = true;
            this.insertMenubutton.Click += new System.EventHandler(this.insertMenubutton_Click);
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.ForeColor = System.Drawing.Color.White;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 77);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Size = new System.Drawing.Size(198, 58);
            this.homeMenuButton.TabIndex = 9;
            this.homeMenuButton.Text = "Home";
            this.homeMenuButton.UseVisualStyleBackColor = true;
            this.homeMenuButton.Click += new System.EventHandler(this.homeMenuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 77);
            this.panel2.TabIndex = 0;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.childFormPanel.Controls.Add(this.pictureBox1);
            this.childFormPanel.Controls.Add(this.panel1);
            this.childFormPanel.Controls.Add(this.PortfolioBalancePanel);
            this.childFormPanel.Controls.Add(this.ProfitPanel);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(198, 41);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(817, 550);
            this.childFormPanel.TabIndex = 9;
            this.childFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childFormPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BTCpriceDisplayLabel);
            this.panel1.Location = new System.Drawing.Point(355, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 148);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current BTC price:";
            // 
            // BTCpriceDisplayLabel
            // 
            this.BTCpriceDisplayLabel.AutoSize = true;
            this.BTCpriceDisplayLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTCpriceDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(105)))), ((int)(((byte)(6)))));
            this.BTCpriceDisplayLabel.Location = new System.Drawing.Point(21, 63);
            this.BTCpriceDisplayLabel.Name = "BTCpriceDisplayLabel";
            this.BTCpriceDisplayLabel.Size = new System.Drawing.Size(84, 42);
            this.BTCpriceDisplayLabel.TabIndex = 2;
            this.BTCpriceDisplayLabel.Text = "0.00";
            // 
            // PortfolioBalancePanel
            // 
            this.PortfolioBalancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PortfolioBalancePanel.Controls.Add(this.balanceLabel);
            this.PortfolioBalancePanel.Controls.Add(this.balanceValueLabel);
            this.PortfolioBalancePanel.Location = new System.Drawing.Point(43, 334);
            this.PortfolioBalancePanel.Name = "PortfolioBalancePanel";
            this.PortfolioBalancePanel.Size = new System.Drawing.Size(282, 148);
            this.PortfolioBalancePanel.TabIndex = 8;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.ForeColor = System.Drawing.Color.White;
            this.balanceLabel.Location = new System.Drawing.Point(18, 35);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(168, 22);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "Portfolio Balance:";
            // 
            // balanceValueLabel
            // 
            this.balanceValueLabel.AutoSize = true;
            this.balanceValueLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceValueLabel.ForeColor = System.Drawing.Color.White;
            this.balanceValueLabel.Location = new System.Drawing.Point(18, 63);
            this.balanceValueLabel.Name = "balanceValueLabel";
            this.balanceValueLabel.Size = new System.Drawing.Size(67, 33);
            this.balanceValueLabel.TabIndex = 3;
            this.balanceValueLabel.Text = "0.00";
            this.balanceValueLabel.Click += new System.EventHandler(this.balanceValueLabel_Click);
            // 
            // ProfitPanel
            // 
            this.ProfitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ProfitPanel.Controls.Add(this.profitLabel);
            this.ProfitPanel.Controls.Add(this.profitValueLabel);
            this.ProfitPanel.ForeColor = System.Drawing.Color.DimGray;
            this.ProfitPanel.Location = new System.Drawing.Point(43, 160);
            this.ProfitPanel.Name = "ProfitPanel";
            this.ProfitPanel.Size = new System.Drawing.Size(282, 148);
            this.ProfitPanel.TabIndex = 7;
            this.ProfitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfitPanel_Paint);
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitLabel.ForeColor = System.Drawing.Color.White;
            this.profitLabel.Location = new System.Drawing.Point(30, 35);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(60, 22);
            this.profitLabel.TabIndex = 5;
            this.profitLabel.Text = "Profit:";
            // 
            // profitValueLabel
            // 
            this.profitValueLabel.AutoSize = true;
            this.profitValueLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitValueLabel.ForeColor = System.Drawing.Color.White;
            this.profitValueLabel.Location = new System.Drawing.Point(30, 63);
            this.profitValueLabel.Name = "profitValueLabel";
            this.profitValueLabel.Size = new System.Drawing.Size(67, 33);
            this.profitValueLabel.TabIndex = 6;
            this.profitValueLabel.Text = "0.00";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.topPanel.Controls.Add(this.chooseCurrencyComboBox);
            this.topPanel.Controls.Add(this.maximiseButton);
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.closeAppButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1015, 41);
            this.topPanel.TabIndex = 10;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // chooseCurrencyComboBox
            // 
            this.chooseCurrencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chooseCurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseCurrencyComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCurrencyComboBox.ForeColor = System.Drawing.Color.White;
            this.chooseCurrencyComboBox.FormattingEnabled = true;
            this.chooseCurrencyComboBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.chooseCurrencyComboBox.Location = new System.Drawing.Point(690, 6);
            this.chooseCurrencyComboBox.Name = "chooseCurrencyComboBox";
            this.chooseCurrencyComboBox.Size = new System.Drawing.Size(121, 29);
            this.chooseCurrencyComboBox.TabIndex = 0;
            this.chooseCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseCurrencyComboBox_SelectedIndexChanged);
            // 
            // maximiseButton
            // 
            this.maximiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximiseButton.FlatAppearance.BorderSize = 0;
            this.maximiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximiseButton.ForeColor = System.Drawing.Color.White;
            this.maximiseButton.Location = new System.Drawing.Point(948, 12);
            this.maximiseButton.Name = "maximiseButton";
            this.maximiseButton.Size = new System.Drawing.Size(25, 23);
            this.maximiseButton.TabIndex = 13;
            this.maximiseButton.Text = "=";
            this.maximiseButton.UseVisualStyleBackColor = true;
            this.maximiseButton.Click += new System.EventHandler(this.maximiseButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(918, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Location = new System.Drawing.Point(979, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(24, 23);
            this.closeAppButton.TabIndex = 11;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 455);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 591);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "mainPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.mainPanel_Resize);
            this.sideMenuPanel.ResumeLayout(false);
            this.childFormPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PortfolioBalancePanel.ResumeLayout(false);
            this.PortfolioBalancePanel.PerformLayout();
            this.ProfitPanel.ResumeLayout(false);
            this.ProfitPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button insertMenubutton;
        private System.Windows.Forms.Button homeMenuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button maximiseButton;
        private System.Windows.Forms.ComboBox chooseCurrencyComboBox;
        private System.Windows.Forms.Label BTCpriceDisplayLabel;
        private System.Windows.Forms.Button viewListButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balanceValueLabel;
        private System.Windows.Forms.Label profitValueLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PortfolioBalancePanel;
        private System.Windows.Forms.Panel ProfitPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


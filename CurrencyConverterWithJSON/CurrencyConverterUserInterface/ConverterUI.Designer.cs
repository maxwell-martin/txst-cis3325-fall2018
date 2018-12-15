namespace CurrencyConverterUserInterface
{
    partial class ConverterUI
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.usDollarTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.lbCurrencies = new System.Windows.Forms.ListBox();
            this.lblConvertedValueOutputDesc = new System.Windows.Forms.Label();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lblExchangeRateOutputDesc = new System.Windows.Forms.Label();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.bsCurrencyRates = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencyRates)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(131, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Currency Converter by Maxwell Martin";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(15, 93);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(203, 17);
            this.instructionsLabel1.TabIndex = 1;
            this.instructionsLabel1.Text = "Enter amount in US dollars ($):";
            // 
            // usDollarTextBox
            // 
            this.usDollarTextBox.Location = new System.Drawing.Point(224, 90);
            this.usDollarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usDollarTextBox.Name = "usDollarTextBox";
            this.usDollarTextBox.Size = new System.Drawing.Size(285, 22);
            this.usDollarTextBox.TabIndex = 2;
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(90, 141);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(205, 17);
            this.instructionsLabel2.TabIndex = 3;
            this.instructionsLabel2.Text = "Select a currency to convert to:";
            this.instructionsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrencies
            // 
            this.lbCurrencies.DataSource = this.bsCurrencyRates;
            this.lbCurrencies.DisplayMember = "Key";
            this.lbCurrencies.FormattingEnabled = true;
            this.lbCurrencies.ItemHeight = 16;
            this.lbCurrencies.Location = new System.Drawing.Point(93, 174);
            this.lbCurrencies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCurrencies.Name = "lbCurrencies";
            this.lbCurrencies.Size = new System.Drawing.Size(201, 132);
            this.lbCurrencies.TabIndex = 4;
            this.lbCurrencies.ValueMember = "Value";
            // 
            // lblConvertedValueOutputDesc
            // 
            this.lblConvertedValueOutputDesc.AutoSize = true;
            this.lblConvertedValueOutputDesc.Location = new System.Drawing.Point(109, 442);
            this.lblConvertedValueOutputDesc.Name = "lblConvertedValueOutputDesc";
            this.lblConvertedValueOutputDesc.Size = new System.Drawing.Size(247, 17);
            this.lblConvertedValueOutputDesc.TabIndex = 5;
            this.lblConvertedValueOutputDesc.Text = "Amount in Selected Foreign Currency:";
            this.lblConvertedValueOutputDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convertedValueLabel.Location = new System.Drawing.Point(113, 471);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(285, 30);
            this.convertedValueLabel.TabIndex = 6;
            this.convertedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(300, 212);
            this.convertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(111, 50);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Con&vert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.RunConverter);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(107, 541);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 50);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearAndReset);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(287, 541);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 50);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitApplication);
            // 
            // lblExchangeRateOutputDesc
            // 
            this.lblExchangeRateOutputDesc.AutoSize = true;
            this.lblExchangeRateOutputDesc.Location = new System.Drawing.Point(109, 337);
            this.lblExchangeRateOutputDesc.Name = "lblExchangeRateOutputDesc";
            this.lblExchangeRateOutputDesc.Size = new System.Drawing.Size(301, 17);
            this.lblExchangeRateOutputDesc.TabIndex = 10;
            this.lblExchangeRateOutputDesc.Text = "Exchange Rate for Selected Foreign Currency:";
            this.lblExchangeRateOutputDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExchangeRate.Location = new System.Drawing.Point(113, 371);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(285, 30);
            this.lblExchangeRate.TabIndex = 11;
            this.lblExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bsCurrencyRates
            // 
            this.bsCurrencyRates.DataSource = typeof(System.Collections.Generic.KeyValuePair<string, double>);
            // 
            // ConverterUI
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(524, 618);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.lblExchangeRateOutputDesc);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.lblConvertedValueOutputDesc);
            this.Controls.Add(this.lbCurrencies);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.usDollarTextBox);
            this.Controls.Add(this.instructionsLabel1);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConverterUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.ConverterUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencyRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.TextBox usDollarTextBox;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.ListBox lbCurrencies;
        private System.Windows.Forms.Label lblConvertedValueOutputDesc;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lblExchangeRateOutputDesc;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.BindingSource bsCurrencyRates;
    }
}


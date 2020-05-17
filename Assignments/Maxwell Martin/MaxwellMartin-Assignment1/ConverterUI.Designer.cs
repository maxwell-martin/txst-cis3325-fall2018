namespace MaxwellMartin_Assignment1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.usDollarTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.currencyListBox = new System.Windows.Forms.ListBox();
            this.outputDescLabel = new System.Windows.Forms.Label();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(151, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Currency Converter by Maxwell Martin";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(35, 95);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(203, 17);
            this.instructionsLabel1.TabIndex = 1;
            this.instructionsLabel1.Text = "Enter amount in US dollars ($):";
            // 
            // usDollarTextBox
            // 
            this.usDollarTextBox.Location = new System.Drawing.Point(244, 92);
            this.usDollarTextBox.Name = "usDollarTextBox";
            this.usDollarTextBox.Size = new System.Drawing.Size(285, 22);
            this.usDollarTextBox.TabIndex = 2;
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(177, 150);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(205, 17);
            this.instructionsLabel2.TabIndex = 3;
            this.instructionsLabel2.Text = "Select a currency to convert to:";
            this.instructionsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyListBox
            // 
            this.currencyListBox.FormattingEnabled = true;
            this.currencyListBox.ItemHeight = 16;
            this.currencyListBox.Location = new System.Drawing.Point(180, 183);
            this.currencyListBox.Name = "currencyListBox";
            this.currencyListBox.Size = new System.Drawing.Size(202, 132);
            this.currencyListBox.TabIndex = 4;
            // 
            // outputDescLabel
            // 
            this.outputDescLabel.AutoSize = true;
            this.outputDescLabel.Location = new System.Drawing.Point(81, 368);
            this.outputDescLabel.Name = "outputDescLabel";
            this.outputDescLabel.Size = new System.Drawing.Size(115, 17);
            this.outputDescLabel.TabIndex = 5;
            this.outputDescLabel.Text = "Converted value:";
            this.outputDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convertedValueLabel.Location = new System.Drawing.Point(202, 356);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(285, 29);
            this.convertedValueLabel.TabIndex = 6;
            this.convertedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(38, 431);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(111, 51);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Con&vert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.RunConverter);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(230, 431);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 51);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearAndReset);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(418, 431);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 51);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitApplication);
            // 
            // ConverterUI
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(564, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.outputDescLabel);
            this.Controls.Add(this.currencyListBox);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.usDollarTextBox);
            this.Controls.Add(this.instructionsLabel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "ConverterUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.ConverterUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.TextBox usDollarTextBox;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.ListBox currencyListBox;
        private System.Windows.Forms.Label outputDescLabel;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


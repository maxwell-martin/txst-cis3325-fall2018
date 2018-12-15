namespace FourFunctionCalculator_v2
{
    partial class Calculator2
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
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.instructionsLabel3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.resultsDescLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(155, 72);
            this.inputTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(281, 20);
            this.inputTextBox1.TabIndex = 0;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(155, 131);
            this.inputTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(281, 20);
            this.inputTextBox2.TabIndex = 1;
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(26, 76);
            this.instructionsLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(106, 13);
            this.instructionsLabel2.TabIndex = 2;
            this.instructionsLabel2.Text = "Enter a number here:";
            // 
            // instructionsLabel3
            // 
            this.instructionsLabel3.AutoSize = true;
            this.instructionsLabel3.Location = new System.Drawing.Point(26, 135);
            this.instructionsLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel3.Name = "instructionsLabel3";
            this.instructionsLabel3.Size = new System.Drawing.Size(106, 13);
            this.instructionsLabel3.TabIndex = 3;
            this.instructionsLabel3.Text = "Enter a number here:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(28, 202);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 76);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(140, 202);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(79, 76);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "-";
            this.subtractButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(249, 202);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(79, 76);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.Text = "*";
            this.multiplyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(356, 202);
            this.divideButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(79, 76);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(118, 28);
            this.instructionsLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(233, 13);
            this.instructionsLabel1.TabIndex = 8;
            this.instructionsLabel1.Text = "Enter in two numbers, and choose an operation.";
            // 
            // resultsDescLabel
            // 
            this.resultsDescLabel.AutoSize = true;
            this.resultsDescLabel.Location = new System.Drawing.Point(131, 332);
            this.resultsDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultsDescLabel.Name = "resultsDescLabel";
            this.resultsDescLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsDescLabel.TabIndex = 9;
            this.resultsDescLabel.Text = "Results:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Location = new System.Drawing.Point(180, 315);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(160, 46);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(75, 391);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 48);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(264, 391);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(130, 48);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Calculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 471);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultsDescLabel);
            this.Controls.Add(this.instructionsLabel1);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.instructionsLabel3);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calculator2";
            this.Text = "Four Function Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.Label instructionsLabel3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.Label resultsDescLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
    }
}


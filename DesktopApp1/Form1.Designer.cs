namespace DesktopApp1
{
    partial class Form1
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextField = new System.Windows.Forms.TextBox();
            this.WeightTextField = new System.Windows.Forms.TextBox();
            this.ResultPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(67, 209);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(291, 87);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(63, 40);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(103, 20);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Enter Height:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(63, 123);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(106, 20);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Enter Weight:";
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // HeightTextField
            // 
            this.HeightTextField.Location = new System.Drawing.Point(67, 76);
            this.HeightTextField.Name = "HeightTextField";
            this.HeightTextField.Size = new System.Drawing.Size(291, 26);
            this.HeightTextField.TabIndex = 3;
            this.HeightTextField.TextChanged += new System.EventHandler(this.HeightTextField_TextChanged);
            // 
            // WeightTextField
            // 
            this.WeightTextField.Location = new System.Drawing.Point(67, 157);
            this.WeightTextField.Name = "WeightTextField";
            this.WeightTextField.Size = new System.Drawing.Size(291, 26);
            this.WeightTextField.TabIndex = 4;
            this.WeightTextField.TextChanged += new System.EventHandler(this.WeightTextField_TextChanged);
            // 
            // ResultPrint
            // 
            this.ResultPrint.AutoSize = true;
            this.ResultPrint.Location = new System.Drawing.Point(63, 309);
            this.ResultPrint.MaximumSize = new System.Drawing.Size(291, 52);
            this.ResultPrint.Name = "ResultPrint";
            this.ResultPrint.Size = new System.Drawing.Size(0, 20);
            this.ResultPrint.TabIndex = 5;
            this.ResultPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 365);
            this.Controls.Add(this.ResultPrint);
            this.Controls.Add(this.WeightTextField);
            this.Controls.Add(this.HeightTextField);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextField;
        private System.Windows.Forms.TextBox WeightTextField;
        private System.Windows.Forms.Label ResultPrint;
    }
}


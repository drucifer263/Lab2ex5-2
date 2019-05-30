namespace FutureValue_5_2_Enhanced
{
    partial class frmFutureValue
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
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.lblYealryInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.AutoSize = true;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(25, 52);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(102, 13);
            this.lblMonthlyInvestment.TabIndex = 0;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            // 
            // lblYealryInterestRate
            // 
            this.lblYealryInterestRate.AutoSize = true;
            this.lblYealryInterestRate.Location = new System.Drawing.Point(25, 87);
            this.lblYealryInterestRate.Name = "lblYealryInterestRate";
            this.lblYealryInterestRate.Size = new System.Drawing.Size(103, 13);
            this.lblYealryInterestRate.TabIndex = 1;
            this.lblYealryInterestRate.Text = "Yearly Interest Rate:";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(25, 124);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(89, 13);
            this.lblNumberOfYears.TabIndex = 2;
            this.lblNumberOfYears.Text = "Number of Years:";
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Location = new System.Drawing.Point(25, 197);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(70, 13);
            this.lblFutureValue.TabIndex = 3;
            this.lblFutureValue.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(133, 52);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyInvestment.TabIndex = 4;
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(133, 87);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtYearlyInterestRate.TabIndex = 5;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(132, 124);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfYears.TabIndex = 6;
            this.txtNumberOfYears.TextChanged += new System.EventHandler(this.txtNumberOfYears_TextChanged);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(132, 190);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
            this.txtFutureValue.TabIndex = 7;
            this.txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(28, 154);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(158, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(28, 13);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(75, 23);
            this.btnEnterData.TabIndex = 10;
            this.btnEnterData.Text = "Enter Data";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // frmFutureValue
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEnterData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblYealryInterestRate);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Name = "frmFutureValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.frmFutureValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.Label lblYealryInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.Button btnEnterData;
    }
}


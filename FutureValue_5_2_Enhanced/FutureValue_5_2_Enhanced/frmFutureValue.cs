using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue_5_2_Enhanced
{
    /*

     Drew Watson
     Lab assignment 2 
     5.2
     Friedman
     Component Spring 2018

    */

    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        //Event handler for when form loads
        private void frmFutureValue_Load(object sender, EventArgs e)
        {
            //Sets up the form
            clearForm();
        }

        //Performs calculations when button pressed
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            decimal monthlyInvestment = 0, yearlyInterestRate = 0, futureValue = 0m;
            int numberOfYears = 0;

            //Taking input and converting to their repective data types
            monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);

            //Called function calculates future value and places in variable
            futureValue = calculateFutureValue(monthlyInvestment, yearlyInterestRate, numberOfYears);

            //Converts and formats futurevalue and places in txtbox
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();

            //Prompt to user
            MessageBox.Show("If you want another calculation press Enter Data button.", "Re-run!");
        }

        //Calculates the future value of investment
        private decimal calculateFutureValue(decimal monthlyInvestment, decimal yearlyInterestRate, int numberOfYears)
        {
            //Variables
            decimal valueOfFuture = 0m, monthlyInterestRate = 0;
            int months = 0;

            //Number of months in a given year
            months = numberOfYears * 12;

            //Monthly interest rate based off of yearly interest rate
            monthlyInterestRate = ((yearlyInterestRate / 12) / 100);

            //Calculates the future value
            for (int i = 0; i < months; i++)
            {
                valueOfFuture = (valueOfFuture + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            //returns the proper value of investment 
            return valueOfFuture;
        }

        //Clears the form
        private void clearForm()
        {

            //Sets txtboxes to blank
            txtMonthlyInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtNumberOfYears.Text = "";
            txtFutureValue.Text = "";

            //Disables the four controls
            lblMonthlyInvestment.Enabled = false;
            txtMonthlyInvestment.Enabled = false;

            lblYealryInterestRate.Enabled = false;
            txtYearlyInterestRate.Enabled = false;

            lblNumberOfYears.Enabled = false;
            txtNumberOfYears.Enabled = false;

            lblFutureValue.Enabled = false;
            txtFutureValue.Enabled = false;

            //Disables calculate button
            btnCalculate.Enabled = false;
        }

        //Enables calculate button when txtNumberOfYear changes
        private void txtNumberOfYears_TextChanged(object sender, EventArgs e)
        {
            //Enables calculate button
            btnCalculate.Enabled = true;
        }

        //Sets up controls 
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            //Enables controls
            lblMonthlyInvestment.Enabled = true;
            txtMonthlyInvestment.Enabled = true;

            lblYealryInterestRate.Enabled = true;
            txtYearlyInterestRate.Enabled = true;

            lblNumberOfYears.Enabled = true;
            txtNumberOfYears.Enabled = true;

            lblFutureValue.Enabled = true;
            txtFutureValue.Enabled = true;

            //Sets txtboxes to blank
            txtMonthlyInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtNumberOfYears.Text = "";
            txtFutureValue.Text = "";

            //Disables calculate button
            btnCalculate.Enabled = false;

            //Sets form focus
            txtMonthlyInvestment.Focus();
        }
        //Closes the form when exit is hit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*

        A few possible advantages of this new design over the original:
        1. Better control 
        2. Easier design for the user
        3. Harder for the user to make mistakes
        4. Allows for the programer to curtail where and what the user does
        5. More interactive and dynamic design
        6. Easier for the user to focus on one thing at a time
        
        */
    }
}

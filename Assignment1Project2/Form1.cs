using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is for the error message button click that tells you, you have an error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErrorMsg_Click(object sender, EventArgs e)
        {
  
            DialogResult MyResult;

            MyResult = MessageBox.Show(txtError.Text + ", you have caused an Error!", "Error Caption!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lblResult.Text = "You clicked " + MyResult.ToString() + "button";
        }

        /// <summary>
        /// this is when you click the yes no button and you decide to keep your job
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYesNo_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            MyResult = MessageBox.Show("Would you like to be a "+ txtYesNo.Text +"?", "Y/N", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            lblResult.Text = "You clicked " + MyResult.ToString() + "button";
        }

        /// <summary>
        /// this is for the retry button click where I phish your password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            MyResult = MessageBox.Show(txtRetry.Text+" is not your password would you like retry that?", "Try Again?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            lblResult.Text = "You clicked " + MyResult.ToString() + " button";
        }
    }
}

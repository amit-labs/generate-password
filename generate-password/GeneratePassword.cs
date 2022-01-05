using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generate_password
{
    public partial class GeneratePassword : Form
    {
        bool checkSymbols, checkNumbers, checkLower, checkUpper;
        public GeneratePassword()
        {
            InitializeComponent();

            checkSymbols = true;
            checkNumbers = true;
            checkLower = true;
            checkUpper = true;
        }

        private void GeneratePassword_Load(object sender, EventArgs e)
        {
            txtLength.Select();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLength.Text))
            {
                txtLength.Select();
                lblMessage.ForeColor = Color.Orange;
                lblMessage.Text = "Enter password length.";
            }
            else
            {
                txtPassword.Text = RandomPassword.Generate(int.Parse(txtLength.Text), checkSymbols, checkNumbers, checkLower, checkUpper);
            }
        }

        private void Length_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLength.Text))
            {
                lblMessage.Text = "";
            }
            else
            {
                if (int.Parse(txtLength.Text) < 16)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Weak Password";
                }
                else
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Strong Password";
                }
            }
        }

        private void Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Symbols_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSymbols.Checked == true)
                checkSymbols = true;
            else
                checkSymbols = false;
        }

        private void Numbers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumbers.Checked == true)
                checkNumbers = true;
            else
                checkNumbers = false;
        }

        private void Lower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLower.Checked == true)
                checkLower = true;
            else
                checkLower = false;
        }

        private void Upper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpper.Checked == true)
                checkUpper = true;
            else
                checkUpper = false;
        }
    }
}

using ATM.ClassLibrary.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.WinForms.Forms
{    
    public partial class WithdrawForm : Form
    {
        private int sum = 0;
        private MainForm mainForm;
        public WithdrawForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetWithdrawHandler(withdrawHandler!);
        }

        private void withdrawHandler(object sender, WithdrawEventArgs e)
        {
            if (e.AccountBalanceLack)
            {
                MessageBox.Show("There is lack of money on your balance.", default, default, MessageBoxIcon.Error);
                return;
            }
            else if (e.ATMCashLack)
            {
                DialogResult result = MessageBox.Show("Sorry. There is lack of cash in ATM. " +
                    "Do you want to withdraw a smaller sum?", default, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tbAmount.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    CloseForm();
                }
                return;
            }

            CloseForm();
        }

        private void CloseForm()
        {
            mainForm.Session.RemoveWithdrawHandler(withdrawHandler!);
            mainForm.OpenMenuForm();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(tbAmount.Text, out amount))
            {
                MessageBox.Show("Enter an integer to the sum field.", default, default, MessageBoxIcon.Error);
                return;
            }            
            
            mainForm.Session.Withdraw(amount);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AddToSum(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = sender as Button;

                int value = 0;
                if (Int32.TryParse(btn.Text, out value))
                {
                    sum += value;
                    tbAmount.Text = sum.ToString();
                }
            }
        }
    }
}

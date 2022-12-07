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
    public partial class TransferForm : Form
    {
        private MainForm mainForm;
        public TransferForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetTransferHandler(transferHandler!);
        }

        private void transferHandler(object sender, TransferEventArgs e)
        {
            if (e.RecipientDoesntExist)
            {
                MessageBox.Show("Recipient doesn't exist.", default, default, MessageBoxIcon.Error);
                return;
            }
            if (e.AccountBalanceLack)
            {
                MessageBox.Show("There is lack of money on your balance.", default, default, MessageBoxIcon.Error);
                return;
            }
            CloseForm();
        }

        private void CloseForm()
        {
            mainForm.Session.RemoveTransferHandler(transferHandler!);
            mainForm.OpenMenuForm();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int sum;
            if (!int.TryParse(tbAmount.Text, out sum))
            {
                MessageBox.Show("Enter an integer to the sum field.", default, default, MessageBoxIcon.Error);
                return;
            }
            if (tbRecipient.Text == "")
            {
                MessageBox.Show("Enter a recipient card number.", default, default, MessageBoxIcon.Error);
                return;
            }

            mainForm.Session.Transfer(tbRecipient.Text, sum);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}

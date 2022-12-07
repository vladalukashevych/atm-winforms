using ATM.ClassLibrary.Classes;
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
    public partial class MenuForm : Form
    {
        private MainForm mainForm;
        public MenuForm(MainForm mainForm)
        {
            InitializeComponent();           
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetCheckBalanceHandler(checkBalanceHandler!);
        }
        public void CloseForm()
        {
            mainForm.Session.RemoveCheckBalanceHandler(checkBalanceHandler!);
            mainForm.OpenAuthorizeForm();
        }

        public void checkBalanceHandler(object sender, CheckBalanceEventArgs e)
        {
            tbBalance.Text = e.Balance.ToString();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            tbWelcome.Text = $"Welcome, {mainForm.Session.Account.FullName}!";
            tbCardNumber.Text = $"{mainForm.Session.Account.CardNumber}";
            mainForm.Session.CheckBalance();
        }

        private void ChooseOption(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnExit":
                        mainForm.OpenAuthorizeForm();
                        break;
                    case "btnPut":
                        mainForm.OpenPutForm();
                        break;
                    case "btnWithdraw":
                        mainForm.OpenWithdrawForm();
                        break;
                    case "btnTransfer":
                        mainForm.OpenTransferForm();
                        break;
                }
            }
        }
    }
}

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
    public partial class PutForm : Form
    {
        private MainForm mainForm;
        private int sum = 0;
        public PutForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            SetHandler();
        }

        private void SetHandler()
        {
            mainForm.Session.SetPutHandler(putHandler!);
        }

        private void putHandler(object sender, AccountEventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            mainForm.Session.RemovePutHandler(putHandler!);
            mainForm.OpenMenuForm();
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(tbAmount.Text, out amount))
            {
                MessageBox.Show("Enter an integer to the sum field.", default, default, MessageBoxIcon.Error);
                return;
            }
            mainForm.Session.Put(amount);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}

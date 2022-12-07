namespace ATM.WinForms.Forms
{
    partial class MenuForm
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
            this.btnPut = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbWelcome = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPut
            // 
            this.btnPut.BackColor = System.Drawing.Color.DarkRed;
            this.btnPut.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPut.ForeColor = System.Drawing.Color.White;
            this.btnPut.Location = new System.Drawing.Point(634, 402);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(462, 95);
            this.btnPut.TabIndex = 0;
            this.btnPut.Text = "Put";
            this.btnPut.UseVisualStyleBackColor = false;
            this.btnPut.Click += new System.EventHandler(this.ChooseOption);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.DarkRed;
            this.btnWithdraw.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(634, 560);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(462, 95);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.ChooseOption);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DarkRed;
            this.btnTransfer.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(84, 402);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(462, 95);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.ChooseOption);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(84, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(462, 95);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ChooseOption);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(295, 256);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(188, 47);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBalance.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBalance.Location = new System.Drawing.Point(505, 253);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(423, 61);
            this.tbBalance.TabIndex = 5;
            this.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWelcome
            // 
            this.tbWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.tbWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWelcome.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWelcome.Location = new System.Drawing.Point(84, 38);
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.Size = new System.Drawing.Size(1012, 76);
            this.tbWelcome.TabIndex = 6;
            this.tbWelcome.Text = "Welcome";
            this.tbWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCardNumber.Location = new System.Drawing.Point(505, 173);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(517, 61);
            this.tbCardNumber.TabIndex = 8;
            this.tbCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardNumber.Location = new System.Drawing.Point(199, 176);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(284, 47);
            this.lblCardNumber.TabIndex = 7;
            this.lblCardNumber.Text = "Card Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(449, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 47);
            this.label1.TabIndex = 9;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.tbWelcome);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnPut);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPut;
        private Button btnWithdraw;
        private Button btnTransfer;
        private Button btnExit;
        private Label lblBalance;
        private TextBox tbBalance;
        private TextBox tbWelcome;
        private TextBox tbCardNumber;
        private Label lblCardNumber;
        private Label label1;
    }
}
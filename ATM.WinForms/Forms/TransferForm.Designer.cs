namespace ATM.WinForms.Forms
{
    partial class TransferForm
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
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRecipient
            // 
            this.tbRecipient.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRecipient.Location = new System.Drawing.Point(530, 281);
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(517, 61);
            this.tbRecipient.TabIndex = 7;
            this.tbRecipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipient.Location = new System.Drawing.Point(214, 284);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(236, 47);
            this.lblRecipient.TabIndex = 6;
            this.lblRecipient.Text = "Recipient";
            // 
            // lblTransfer
            // 
            this.lblTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransfer.Location = new System.Drawing.Point(443, 97);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(323, 74);
            this.lblTransfer.TabIndex = 5;
            this.lblTransfer.Text = "Transfer";
            this.lblTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(779, 586);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(268, 78);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(530, 389);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(517, 61);
            this.tbAmount.TabIndex = 10;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(286, 392);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(164, 47);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(148, 586);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(268, 78);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbRecipient);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.lblTransfer);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbRecipient;
        private Label lblRecipient;
        private Label lblTransfer;
        private Button btnEnter;
        private TextBox tbAmount;
        private Label lblAmount;
        private Button btnBack;
    }
}
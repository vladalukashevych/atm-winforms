namespace ATM.WinForms.Forms
{
    partial class PutForm
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblPut = new System.Windows.Forms.Label();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(680, 637);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(268, 78);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.White;
            this.tbAmount.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(413, 189);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(506, 61);
            this.tbAmount.TabIndex = 11;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPut
            // 
            this.lblPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPut.AutoSize = true;
            this.lblPut.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPut.Location = new System.Drawing.Point(537, 51);
            this.lblPut.Name = "lblPut";
            this.lblPut.Size = new System.Drawing.Size(152, 74);
            this.lblPut.TabIndex = 7;
            this.lblPut.Text = "Put";
            this.lblPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.DarkRed;
            this.btn10.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn10.ForeColor = System.Drawing.Color.White;
            this.btn10.Location = new System.Drawing.Point(111, 310);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(408, 70);
            this.btn10.TabIndex = 14;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.AddToSum);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.DarkRed;
            this.btn100.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn100.ForeColor = System.Drawing.Color.White;
            this.btn100.Location = new System.Drawing.Point(680, 310);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(408, 70);
            this.btn100.TabIndex = 13;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.AddToSum);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.DarkRed;
            this.btn20.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn20.ForeColor = System.Drawing.Color.White;
            this.btn20.Location = new System.Drawing.Point(111, 407);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(408, 70);
            this.btn20.TabIndex = 16;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.AddToSum);
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.DarkRed;
            this.btn200.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn200.ForeColor = System.Drawing.Color.White;
            this.btn200.Location = new System.Drawing.Point(680, 407);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(408, 70);
            this.btn200.TabIndex = 15;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = false;
            this.btn200.Click += new System.EventHandler(this.AddToSum);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.DarkRed;
            this.btn50.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn50.ForeColor = System.Drawing.Color.White;
            this.btn50.Location = new System.Drawing.Point(111, 503);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(408, 70);
            this.btn50.TabIndex = 18;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.AddToSum);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.DarkRed;
            this.btn500.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(680, 503);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(408, 70);
            this.btn500.TabIndex = 17;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.AddToSum);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(251, 637);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(268, 78);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(207, 192);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(164, 47);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount";
            // 
            // PutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblPut);
            this.Name = "PutForm";
            this.Text = "PutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnter;
        private TextBox tbAmount;
        private Label lblPut;
        private Button btn10;
        private Button btn100;
        private Button btn20;
        private Button btn200;
        private Button btn50;
        private Button btn500;
        private Button btnBack;
        private Label lblAmount;
    }
}
namespace DB_jay
{   
    partial class Log_in
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
            this.lblogin = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("굴림", 30F);
            this.lblogin.Location = new System.Drawing.Point(126, 32);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(172, 50);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "로그인";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(205, 115);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(198, 25);
            this.tbID.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(205, 155);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(198, 25);
            this.tbPass.TabIndex = 2;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("굴림", 20F);
            this.lbUser.Location = new System.Drawing.Point(129, 112);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 34);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "ID";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(79, 210);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(104, 49);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("굴림", 20F);
            this.lbPass.Location = new System.Drawing.Point(12, 146);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(171, 34);
            this.lbPass.TabIndex = 5;
            this.lbPass.Text = "Password";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(230, 210);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(104, 49);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 286);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblogin);
            this.Name = "Log_in";
            this.Text = "Log_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btClose;
    }
}
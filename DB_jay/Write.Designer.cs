namespace DB_jay
{
    partial class Write
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "사용자 :";
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(130, 175);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(435, 195);
            this.tbBody.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.Location = new System.Drawing.Point(26, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "본문";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("굴림", 17F);
            this.lbUser.Location = new System.Drawing.Point(153, 19);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(100, 29);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "사용자";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(316, 63);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(115, 50);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(451, 63);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(115, 50);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(130, 137);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(435, 32);
            this.tbTitle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20F);
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "제목";
            // 
            // Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.label1);
            this.Name = "Write";
            this.Text = "Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label3;
    }
}
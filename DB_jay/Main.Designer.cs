namespace DB_jay
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCon = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRepair = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btJoin = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCon
            // 
            this.btCon.Location = new System.Drawing.Point(371, 9);
            this.btCon.Name = "btCon";
            this.btCon.Size = new System.Drawing.Size(90, 43);
            this.btCon.TabIndex = 0;
            this.btCon.Text = "Reload";
            this.btCon.UseVisualStyleBackColor = true;
            this.btCon.Click += new System.EventHandler(this.btCon_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 175);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.Size = new System.Drawing.Size(484, 359);
            this.dgv1.TabIndex = 1;
            this.dgv1.VirtualMode = true;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 144);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(386, 25);
            this.tbSearch.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(404, 144);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(92, 25);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "검색";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(12, 102);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(92, 25);
            this.btWrite.TabIndex = 4;
            this.btWrite.Text = "글쓰기";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRepair
            // 
            this.btRepair.Location = new System.Drawing.Point(110, 102);
            this.btRepair.Name = "btRepair";
            this.btRepair.Size = new System.Drawing.Size(92, 25);
            this.btRepair.TabIndex = 5;
            this.btRepair.Text = "수정";
            this.btRepair.UseVisualStyleBackColor = true;
            this.btRepair.Click += new System.EventHandler(this.btRepair_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(208, 102);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(92, 25);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "삭제";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btJoin
            // 
            this.btJoin.Location = new System.Drawing.Point(306, 102);
            this.btJoin.Name = "btJoin";
            this.btJoin.Size = new System.Drawing.Size(92, 25);
            this.btJoin.TabIndex = 7;
            this.btJoin.Text = "회원가입";
            this.btJoin.UseVisualStyleBackColor = true;
            this.btJoin.Click += new System.EventHandler(this.btJoin_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("굴림", 50F);
            this.lbTitle.ForeColor = System.Drawing.Color.Lime;
            this.lbTitle.Location = new System.Drawing.Point(11, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(486, 84);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Free Forum";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(404, 102);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(92, 25);
            this.btLogin.TabIndex = 9;
            this.btLogin.Text = "로그인";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.tbDate);
            this.pn.Controls.Add(this.tbTitle);
            this.pn.Controls.Add(this.tbUser);
            this.pn.Controls.Add(this.tbBody);
            this.pn.Controls.Add(this.btCon);
            this.pn.Location = new System.Drawing.Point(512, 27);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(477, 507);
            this.pn.TabIndex = 10;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(178, 20);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(163, 25);
            this.tbDate.TabIndex = 12;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 58);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(449, 25);
            this.tbTitle.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(12, 20);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(139, 25);
            this.tbUser.TabIndex = 1;
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(12, 96);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(449, 398);
            this.tbBody.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btJoin);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btRepair);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgv1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCon;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRepair;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btJoin;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbDate;
        public System.Windows.Forms.Button btLogin;
        public System.Windows.Forms.TextBox tbTitle;
        public System.Windows.Forms.TextBox tbBody;
    }
}


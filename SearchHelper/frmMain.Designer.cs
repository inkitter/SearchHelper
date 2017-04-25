namespace SearchHelper
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.BtnGoogle = new System.Windows.Forms.Button();
            this.BtnBaidu = new System.Windows.Forms.Button();
            this.BtnDictYoudao = new System.Windows.Forms.Button();
            this.BtnDictBaidu = new System.Windows.Forms.Button();
            this.BtnDictGoogle = new System.Windows.Forms.Button();
            this.BtnDictCB = new System.Windows.Forms.Button();
            this.BtnGoogleSch = new System.Windows.Forms.Button();
            this.BtnZhihu = new System.Windows.Forms.Button();
            this.BtnTaobao = new System.Windows.Forms.Button();
            this.BtnSciHub = new System.Windows.Forms.Button();
            this.ChkTopMost = new System.Windows.Forms.CheckBox();
            this.MnuExit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnInkitorg = new System.Windows.Forms.Button();
            this.MnuExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtSearch.Location = new System.Drawing.Point(4, 11);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(315, 29);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.Text = "输入要搜索的内容";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(6, 134);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(313, 130);
            this.TxtLog.TabIndex = 1;
            // 
            // BtnGoogle
            // 
            this.BtnGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnGoogle.FlatAppearance.BorderSize = 0;
            this.BtnGoogle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoogle.Location = new System.Drawing.Point(5, 44);
            this.BtnGoogle.Name = "BtnGoogle";
            this.BtnGoogle.Size = new System.Drawing.Size(74, 24);
            this.BtnGoogle.TabIndex = 2;
            this.BtnGoogle.Text = "谷歌";
            this.BtnGoogle.UseVisualStyleBackColor = false;
            this.BtnGoogle.Click += new System.EventHandler(this.BtnGoogle_Click);
            // 
            // BtnBaidu
            // 
            this.BtnBaidu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnBaidu.FlatAppearance.BorderSize = 0;
            this.BtnBaidu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnBaidu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaidu.Location = new System.Drawing.Point(86, 44);
            this.BtnBaidu.Name = "BtnBaidu";
            this.BtnBaidu.Size = new System.Drawing.Size(74, 24);
            this.BtnBaidu.TabIndex = 3;
            this.BtnBaidu.Text = "百度";
            this.BtnBaidu.UseVisualStyleBackColor = false;
            this.BtnBaidu.Click += new System.EventHandler(this.BtnBaidu_Click);
            // 
            // BtnDictYoudao
            // 
            this.BtnDictYoudao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnDictYoudao.FlatAppearance.BorderSize = 0;
            this.BtnDictYoudao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnDictYoudao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDictYoudao.Location = new System.Drawing.Point(245, 44);
            this.BtnDictYoudao.Name = "BtnDictYoudao";
            this.BtnDictYoudao.Size = new System.Drawing.Size(74, 24);
            this.BtnDictYoudao.TabIndex = 4;
            this.BtnDictYoudao.Text = "有道词典";
            this.BtnDictYoudao.UseVisualStyleBackColor = false;
            this.BtnDictYoudao.Click += new System.EventHandler(this.BtnDictYoudao_Click);
            // 
            // BtnDictBaidu
            // 
            this.BtnDictBaidu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnDictBaidu.FlatAppearance.BorderSize = 0;
            this.BtnDictBaidu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnDictBaidu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDictBaidu.Location = new System.Drawing.Point(165, 44);
            this.BtnDictBaidu.Name = "BtnDictBaidu";
            this.BtnDictBaidu.Size = new System.Drawing.Size(74, 24);
            this.BtnDictBaidu.TabIndex = 5;
            this.BtnDictBaidu.Text = "百度翻译";
            this.BtnDictBaidu.UseVisualStyleBackColor = false;
            this.BtnDictBaidu.Click += new System.EventHandler(this.BtnDictBaidu_Click);
            // 
            // BtnDictGoogle
            // 
            this.BtnDictGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnDictGoogle.FlatAppearance.BorderSize = 0;
            this.BtnDictGoogle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnDictGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDictGoogle.Location = new System.Drawing.Point(165, 74);
            this.BtnDictGoogle.Name = "BtnDictGoogle";
            this.BtnDictGoogle.Size = new System.Drawing.Size(74, 24);
            this.BtnDictGoogle.TabIndex = 6;
            this.BtnDictGoogle.Text = "谷歌翻译";
            this.BtnDictGoogle.UseVisualStyleBackColor = false;
            this.BtnDictGoogle.Click += new System.EventHandler(this.BtnDictGoogle_Click);
            // 
            // BtnDictCB
            // 
            this.BtnDictCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnDictCB.FlatAppearance.BorderSize = 0;
            this.BtnDictCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnDictCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDictCB.Location = new System.Drawing.Point(85, 74);
            this.BtnDictCB.Name = "BtnDictCB";
            this.BtnDictCB.Size = new System.Drawing.Size(74, 24);
            this.BtnDictCB.TabIndex = 7;
            this.BtnDictCB.Text = "金山词霸";
            this.BtnDictCB.UseVisualStyleBackColor = false;
            this.BtnDictCB.Click += new System.EventHandler(this.BtnDictCB_Click);
            // 
            // BtnGoogleSch
            // 
            this.BtnGoogleSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnGoogleSch.FlatAppearance.BorderSize = 0;
            this.BtnGoogleSch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnGoogleSch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoogleSch.Location = new System.Drawing.Point(5, 74);
            this.BtnGoogleSch.Name = "BtnGoogleSch";
            this.BtnGoogleSch.Size = new System.Drawing.Size(74, 24);
            this.BtnGoogleSch.TabIndex = 8;
            this.BtnGoogleSch.Text = "谷歌学术";
            this.BtnGoogleSch.UseVisualStyleBackColor = false;
            this.BtnGoogleSch.Click += new System.EventHandler(this.BtnGoogleSch_Click);
            // 
            // BtnZhihu
            // 
            this.BtnZhihu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnZhihu.FlatAppearance.BorderSize = 0;
            this.BtnZhihu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnZhihu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZhihu.Location = new System.Drawing.Point(85, 104);
            this.BtnZhihu.Name = "BtnZhihu";
            this.BtnZhihu.Size = new System.Drawing.Size(74, 24);
            this.BtnZhihu.TabIndex = 9;
            this.BtnZhihu.Text = "知乎";
            this.BtnZhihu.UseVisualStyleBackColor = false;
            this.BtnZhihu.Click += new System.EventHandler(this.BtnZhihu_Click);
            // 
            // BtnTaobao
            // 
            this.BtnTaobao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnTaobao.FlatAppearance.BorderSize = 0;
            this.BtnTaobao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnTaobao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaobao.Location = new System.Drawing.Point(6, 104);
            this.BtnTaobao.Name = "BtnTaobao";
            this.BtnTaobao.Size = new System.Drawing.Size(74, 24);
            this.BtnTaobao.TabIndex = 10;
            this.BtnTaobao.Text = "淘宝";
            this.BtnTaobao.UseVisualStyleBackColor = false;
            this.BtnTaobao.Click += new System.EventHandler(this.BtnTaobao_Click);
            // 
            // BtnSciHub
            // 
            this.BtnSciHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnSciHub.FlatAppearance.BorderSize = 0;
            this.BtnSciHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnSciHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSciHub.Location = new System.Drawing.Point(245, 74);
            this.BtnSciHub.Name = "BtnSciHub";
            this.BtnSciHub.Size = new System.Drawing.Size(74, 24);
            this.BtnSciHub.TabIndex = 11;
            this.BtnSciHub.Text = "Sci-Hub";
            this.BtnSciHub.UseVisualStyleBackColor = false;
            this.BtnSciHub.Click += new System.EventHandler(this.BtnSciHub_Click);
            // 
            // ChkTopMost
            // 
            this.ChkTopMost.AutoSize = true;
            this.ChkTopMost.Checked = true;
            this.ChkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTopMost.Location = new System.Drawing.Point(247, 112);
            this.ChkTopMost.Name = "ChkTopMost";
            this.ChkTopMost.Size = new System.Drawing.Size(72, 16);
            this.ChkTopMost.TabIndex = 12;
            this.ChkTopMost.Text = "总在最前";
            this.ChkTopMost.UseVisualStyleBackColor = true;
            this.ChkTopMost.CheckedChanged += new System.EventHandler(this.ChkTopMost_CheckedChanged);
            // 
            // MnuExit
            // 
            this.MnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(97, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BtnInkitorg
            // 
            this.BtnInkitorg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BtnInkitorg.FlatAppearance.BorderSize = 0;
            this.BtnInkitorg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.BtnInkitorg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInkitorg.Location = new System.Drawing.Point(165, 104);
            this.BtnInkitorg.Name = "BtnInkitorg";
            this.BtnInkitorg.Size = new System.Drawing.Size(33, 24);
            this.BtnInkitorg.TabIndex = 14;
            this.BtnInkitorg.Text = "I";
            this.BtnInkitorg.UseVisualStyleBackColor = false;
            this.BtnInkitorg.Click += new System.EventHandler(this.BtnInkitorg_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(326, 272);
            this.ControlBox = false;
            this.Controls.Add(this.BtnInkitorg);
            this.Controls.Add(this.ChkTopMost);
            this.Controls.Add(this.BtnSciHub);
            this.Controls.Add(this.BtnTaobao);
            this.Controls.Add(this.BtnZhihu);
            this.Controls.Add(this.BtnGoogleSch);
            this.Controls.Add(this.BtnDictCB);
            this.Controls.Add(this.BtnDictGoogle);
            this.Controls.Add(this.BtnDictBaidu);
            this.Controls.Add(this.BtnDictYoudao);
            this.Controls.Add(this.BtnBaidu);
            this.Controls.Add(this.BtnGoogle);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.TxtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search Helper";
            this.Activated += new System.EventHandler(this.frmMain_GotFocus);
            this.Deactivate += new System.EventHandler(this.frmMain_LostFocus);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GotFocus += new System.EventHandler(this.frmMain_GotFocus);
            this.LostFocus += new System.EventHandler(this.frmMain_LostFocus);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmMain_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.MnuExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button BtnGoogle;
        private System.Windows.Forms.Button BtnBaidu;
        private System.Windows.Forms.Button BtnDictYoudao;
        private System.Windows.Forms.Button BtnDictBaidu;
        private System.Windows.Forms.Button BtnDictGoogle;
        private System.Windows.Forms.Button BtnDictCB;
        private System.Windows.Forms.Button BtnGoogleSch;
        private System.Windows.Forms.Button BtnZhihu;
        private System.Windows.Forms.Button BtnTaobao;
        private System.Windows.Forms.Button BtnSciHub;
        private System.Windows.Forms.CheckBox ChkTopMost;
        private System.Windows.Forms.ContextMenuStrip MnuExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnInkitorg;
    }
}


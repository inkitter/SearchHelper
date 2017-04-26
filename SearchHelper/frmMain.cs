using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SearchHelper
{
    public partial class frmMain : Form
    {
        private bool mouseDown;
        private bool frmFocused;
        private bool frmMouseHover;
        private Point lastLocation;
        NotifyIcon Myicon = new NotifyIcon();

        private void frmMain_Load(object sender, EventArgs e)
        {
            IniControl();
            ChkTopMost_CheckedChanged(sender, e);
            FormOpacity();
        }

        private void IniControl()
        {
            Height = 133;
            foreach (Control c in this.Controls)
            {
                c.MouseHover += new EventHandler(frmMain_MouseHover);
            }
            Myicon.Icon = Icon;
            Myicon.DoubleClick += MyIcon_DoubleClick;
            Myicon.Visible = true;

        }
        private void MyIcon_DoubleClick(object sender, EventArgs e)
        {
            Activate();
            Opacity = 1;
        }
        private void FormOpacity()
        {
            double op = 0;
            double opf, oph;
            if (frmFocused) { opf = 0.7; } else { opf = 0; }
            if (frmMouseHover) { oph = 0.7; } else { oph = 0.3; }
            op = opf + oph;
            if (op > 1) { op = 1; }
            Opacity = op;
        }
        private void frmMouseOut()
        {
            if (Cursor.Position.X < Location.X | Cursor.Position.X > Location.X + Width | Cursor.Position.Y < Location.Y | Cursor.Position.Y > Location.Y + Height)
            {
                frmMouseHover = false;
            }
            FormOpacity();
            changesize();
        }
        private async void changesize()
        {
            Task<string> getpause = new Task<string>(tsleep);
            getpause.Start();
            if (await getpause=="2")
            {
                if (!frmMouseHover) { Height = 74; }
            }
            getpause.Dispose();
        }
        private string tsleep()
        {
            Thread.Sleep(1000);
            return "2";
        }

        private void frmMouseIn()
        {
            frmMouseHover = true;
            FormOpacity();
            Height = 133;
        }
        
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_MouseHover(object sender, EventArgs e)
        {
            frmMouseIn();
        }

        private void frmMain_MouseLeave(object sender, EventArgs e)
        {
            frmMouseOut();
        }

        private void frmMain_GotFocus(object sender, EventArgs e)
        {
            frmFocused = true;
            FormOpacity();
        }
        private void frmMain_LostFocus(object sender, EventArgs e)
        {
            frmFocused = false;
            FormOpacity();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BtnGoogle_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "google"));
        }

        private void BtnBaidu_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "baidu"));
        }

        private void BtnDictGoogle_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "dictgoogle"));
        }

        private void BtnDictBaidu_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "dictbaidu"));
        }

        private void BtnDictYoudao_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "dictyoudao"));
        }

        private void BtnDictCB_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "dictciba"));
        }

        private void BtnGoogleSch_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "googlesch"));
        }

        private void BtnSciHub_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "scihub"));
        }

        private void BtnTaobao_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "taobao"));
        }

        private void BtnZhihu_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "zhihu"));
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ChkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTopMost.Checked) { TopMost = true; }
            else { TopMost = false; }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            FormOpacity();
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            FormOpacity();
        }

        private void frmMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Height != 272) { Height = 272; }
            else { Height = 133; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { MnuExit.Show(this,new Point(e.X,e.Y)); }
        }

        private void BtnInkitorg_Click(object sender, EventArgs e)
        {
            SearchEngines.OpenURL(SearchEngines.BuildURL(TxtSearch.Text, "inkit"));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Myicon.Dispose();
        }
    }
}

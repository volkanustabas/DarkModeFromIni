using System;
using System.Drawing;
using System.Windows.Forms;

namespace DarkModeFromIni
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            GetIni();
        }

        private void GetIni()
        {
            var getSettings = new Settings();
            getSettings.ReadIni();
            if (getSettings.Theme == "dark")
            {
                BackColor = Color.FromArgb(32, 33, 36);
                ForeColor = Color.White;
                btn_dark.ForeColor = Color.Chocolate;
                lbl_info.Text = @"DARK";
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.FromArgb(32, 33, 36);
                btn_light.ForeColor = Color.Chocolate;
                lbl_info.Text = @"LIGHT";
            }
        }

        private void btn_dark_Click(object sender, EventArgs e)
        {
            var setDark = new Settings();
            setDark.WriteIni("SECTION", "key", "dark");
            BackColor = Color.FromArgb(32, 33, 36);
            ForeColor = Color.White;
            btn_dark.ForeColor = Color.Chocolate;
            lbl_info.Text = @"DARK";
        }

        private void btn_light_Click(object sender, EventArgs e)
        {
            var setLight = new Settings();
            setLight.WriteIni("SECTION", "key", "light");
            BackColor = Color.White;
            ForeColor = Color.FromArgb(32, 33, 36);
            btn_light.ForeColor = Color.Chocolate;
            lbl_info.Text = @"LIGHT";
        }
    }
}
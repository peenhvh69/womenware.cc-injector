using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Womenwarezz
{
    
    public partial class Main : Form
    {
        private SoundPlayer _soundplayer;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn 
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        Point lastPoint;

        public Main()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            button1.Height = button2.Height;
            button1.Top = button2.Top;
            button1.Left = button2.Left;
            button1.Height = button2.Height;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "HOME";
            this.panel4.Controls.Clear();
            home frmDashboard_vrb = new home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
            _soundplayer = new SoundPlayer("Music.wav");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);

            label3.Text = "HOME";
            this.panel4.Controls.Clear();
            home frmDashboard_vrb = new home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
            _soundplayer = new SoundPlayer("Music.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Height = button2.Height;
            button1.Top = button2.Top;
            button1.Left = button2.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "HOME";
            this.panel4.Controls.Clear();
            home frmDashboard_vrb = new home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Height = button6.Height;
            button1.Top = button6.Top;
            button6.BackColor = Color.FromArgb(46, 51, 73);

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Height = button2.Height;
            button1.Top = button2.Top;
            button2.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "CSGO";
            this.panel4.Controls.Clear();
            csgo frmDashboard_vrb = new csgo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Height = button3.Height;
            button1.Top = button3.Top;
            button3.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "ROBLOX";
            this.panel4.Controls.Clear();
            Roblox frmDashboard_vrb = new Roblox() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Height = button4.Height;
            button1.Top = button4.Top;
            button4.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "OTHER";
            this.panel4.Controls.Clear();
            other frmDashboard_vrb = new other() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Height = button5.Height;
            button1.Top = button5.Top;
            button5.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "CONTACT US";
            this.panel4.Controls.Clear();
            contactus frmDashboard_vrb = new contactus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255); label3.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Height = button10.Height;
            button1.Top = button10.Top;
            button10.BackColor = Color.FromArgb(46, 51, 73);

            label3.Text = "ABOUT US";
            this.panel4.Controls.Clear();
            aboutus frmDashboard_vrb = new aboutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void button10_Leave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
                _soundplayer.Stop();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            _soundplayer.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _soundplayer.Stop();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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


namespace Womenwarezz
{

    public partial class Womenware : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public Womenware()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar1.Value = 0;
        }
        Point lastPoint;
        private void Womenware_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255); label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();  //current form will hide
            Main fm = new Main(); //another form will open
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 2;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value == 100)
            {
                timer2.Enabled = false;
                Main se_form = new Main();
                this.Hide();
                se_form.Show();
            }
        }
    }
}

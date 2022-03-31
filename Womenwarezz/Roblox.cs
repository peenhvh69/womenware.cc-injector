using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EasyExploits;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Womenwarezz
{

    
    public partial class Roblox : Form
    {
        public Roblox()
        {
            InitializeComponent();
        }
        EasyExploits.Module module = new EasyExploits.Module();

        private void Roblox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            module.ExecuteScript(script);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = fastColoredTextBox1.Text;
            text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var scripthub = new scripthub();
            scripthub.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

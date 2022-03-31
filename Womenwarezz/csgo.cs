using ManualMapInjection.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Womenwarezz
{
    public partial class csgo : Form
    {


        public csgo()
        {
            InitializeComponent();
        }

      

        private void csgo_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            string mainpath = "C:\\Windows\\CSGO\\lebro_otc.dll"; //You can change the path to wherever you want but just remember to use "\\" instead of just one "\"
            var name = "csgo"; //Replace "csgo" with any exe you want [Example: For Team Fortress 2 you would replace it with "hl2"]
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            var path = mainpath;
            var file = File.ReadAllBytes(path);

            //Checking if the DLL isn't found
            if (!File.Exists(path))
            {
                MessageBox.Show("Error: DLL not found");
                return;
            }

            //Injection, just leave this alone if you are a beginner
            var injector = new ManualMapInjector(target) { AsyncInjection = true };
            label1.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";
        }
    }
}


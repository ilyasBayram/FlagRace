using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace FlagRace
{
    public partial class Form1 : Form
    {

        int number;

        string continent;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxConitinents.Text = "All World";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            continent = cmBoxConitinents.Text;

            string[] files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", continent));

            number = random.Next(0, files.Length);

            string index = Path.GetFileNameWithoutExtension(files[number]); ;

            
            Image imgReal = Image.FromFile(files[number]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            btnA.Text = index;








        }
    }
}

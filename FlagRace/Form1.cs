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

namespace FlagRace
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbFlag;Integrated Security=True");


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

            int number=random.Next(1, 5);

            Image img = Image.FromFile(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}.png", number));

            pctBoxFlag.Image = img;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;








        }
    }
}

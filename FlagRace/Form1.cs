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
        Random random = new Random();

        ArrayList usedNumbers = new ArrayList();

        int numberReal;

        int numberWrong;

        string continent;

        void getQuestion()
        {
            
            continent = cmBoxConitinents.Text;

            string[] files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", continent));

            if (usedNumbers.Count == files.Length)

                usedNumbers.Clear();


            numberReal = random.Next(files.Length);

            usedNumbers.Add(numberReal);

            numberWrong = random.Next(files.Length);

            while (true)
            {
                if (usedNumbers.Contains(numberReal) == true || numberReal==numberRea)
                {
                    numberReal = random.Next(files.Length);
                }
                
            }

            string indexReal = Path.GetFileNameWithoutExtension(files[numberReal]);

            string indexfake = Path.GetFileNameWithoutExtension(files[numberWrong]);

            Image imgReal = Image.FromFile(files[numberReal]);

            pctBoxFlag.Image = imgReal;

            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            btnA.Text = indexReal;
            btnB.Text = indexfake;

        }
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
            getQuestion();

        }

    }
}

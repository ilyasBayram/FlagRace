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

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
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
            pctBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;

            connection.Open();
            SqlCommand cmd = new SqlCommand("select flag from TblFlag where name='Turkey'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Flag"]);
                pctBoxFlag.Image = new Bitmap(ms);
            }

            connection.Close();
        }
    }
}

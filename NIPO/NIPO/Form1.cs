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
using NIPO.Base;

namespace NIPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.InitialDirectory = "C:\\";    //打开对话框后的初始目录
            this.saveFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            this.saveFileDialog1.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(System.IO.Path.GetFullPath(saveFileDialog1.FileName));//将选中的文件的路径传递给TextBox “FilePath”);
            //}
            Connection conn= new Connection();
            SqlDataReader db = conn.db();
            List<string[]> srrinvalue = new List<string[]>();
            if(db.Read()  ==true)
                {
                string[] a = new string[] { };
                MessageBox.Show(db.FieldCount.ToString());
                db.GetValues(a);
                Console.Write(a);
            }

        }
    }
}

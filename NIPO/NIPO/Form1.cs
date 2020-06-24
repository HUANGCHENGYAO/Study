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
            this.saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);    //打开对话框后的初始目录
            this.saveFileDialog1.Filter = "xlsx文件|*.xlsx|所有文件|*.*";
            this.saveFileDialog1.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.Filter.ToString());
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);    //打开对话框后的初始目录
            this.openFileDialog1.Filter = "xlsx文件|*.txt|所有文件|*.*";
            this.openFileDialog1.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.SafeFileName);
           
        }
    }
}

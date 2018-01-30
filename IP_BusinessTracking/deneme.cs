using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_BusinessTracking
{
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           // dataGridView1.AutoGenerateColumns = false;
           // var imageCol = new DataGridViewImageColumn();
           // var textCol = new DataGridViewTextBoxColumn();
           // imageCol.DataPropertyName = "Photo";
           // textCol.DataPropertyName = "Name";
           //// Image im = Image.FromFile(@"C:\Users\Cemal\Desktop\8847_1.jpg");
            
           // var dt = new DataTable();
           // dt.Columns.Add("", typeof(Image));
           // dt.Columns.Add("");
           // dt.Rows.Add(Image.FromFile(@"C:\Users\Cemal\Desktop\pug.png"), "CEMAL BAYRI");
           // textCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           // imageCol.DefaultCellStyle.Padding = new Padding(0, 0, 100, 0);

           // dataGridView1.GridColor = Color.White;
           // dataGridView1.DataSource = dt;
           // foreach (DataGridViewColumn item in dataGridView1.Columns)
           // {
           //     item.DefaultCellStyle.Font = new Font("Lucida Console", 13.8F,GraphicsUnit.Pixel);
           // }
           // dataGridView1.Rows[0].Selected = false;
        
            Image im = Image.FromFile(@"C:\Users\Cemal\Desktop\pug.png");
            dataGridView1.Rows.Add( new Bitmap(im),"test", "test2");
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Font = new Font("Lucida Console", 13.8F,GraphicsUnit.Pixel);
            }

        }

        private void deneme_Load(object sender, EventArgs e)
        {
        //    dataGridView1.Columns.Add("","");
        //    dataGridView1.Rows.Add();
            var imageCol = new DataGridViewImageColumn();
            dataGridView1.Columns.Add(imageCol);
            dataGridView1.Columns.Add("", "");
            dataGridView1.Columns.Add("", "");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            richTextBox1.Text = x.ToString() + "          " + y.ToString();
            int formWidth = main.Size.Width;
            

        }
    }
}

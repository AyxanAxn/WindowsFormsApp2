using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public PictureBox mouse { get; set; }
        public PictureBox cat{ get; set; }

        public PictureBox Cat{ get; set; }
        public Form1()
        {
            InitializeComponent();
            mouse = new PictureBox();
            mouse.Image= Properties.Resources.mouse2;
            mouse.Size = new Size(100,100);
            mouse.Location = new Point(200,500);
            mouse.SizeMode = PictureBoxSizeMode.StretchImage;
            cat = new PictureBox();
            mouse.MouseMove += Mouse_MouseMove;
            this.Controls.Add(cat);
            this.Controls.Add(mouse);
           // cat.MouseMove += Cat_MouseMove;
            Cursor = new Cursor(Properties.Resources.cat.GetHicon());
            
            Cursor.Show();

        }

        private void Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            Random X = new Random();
            Random Y = new Random();
           

            mouse.Location = new Point(X.Next(e.X,this.Size.Width-150), Y.Next(e.Y,this.Size.Height-150));


        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

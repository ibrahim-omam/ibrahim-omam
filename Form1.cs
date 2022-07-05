using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_of_the_Faculty_of_Informatics_Engineering
{
    public partial class main_form : Form
    {
        private Rectangle buttnonOriginalRectangle;
        private Rectangle originalFormSize;
        private int cresize = 0;

        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            buttnonOriginalRectangle = new Rectangle(button1.Location.X,button1.Location.Y,button1.Width,button1.Height);

        }
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void main_form_Resize(object sender, EventArgs e)
        {
            if (cresize > 0)
            {
                resizeControl(buttnonOriginalRectangle, button1);
            }
            cresize++;
        }
    }
}

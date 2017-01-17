using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal higherZ_RecZoom { private set; get; }
        public decimal lowerZ_RecZoom { private set; get; }
        public int divideZ_RecZoom { private set; get; }
        public decimal x1_RecZoom { private set; get; }
        public decimal y1_RecZoom { private set; get; }
        public decimal x2_RecZoom { private set; get; }
        public decimal y2_RecZoom { private set; get; }
        public int divideHori_RecZoom { private set; get; }
        public decimal precision_RecZoom { private set; get; }



        private void button1_Click(object sender, EventArgs e)
        {
            this.higherZ_RecZoom = decimal.Parse(higherZ_RectZone.Text);//text控件需要转换为string还是本身就是string？
            this.lowerZ_RecZoom = decimal.Parse(lowerZ_RectZoom.Text);
            this.divideZ_RecZoom = Convert.ToInt32(divideZ_RectZoom);
            this.x1_RecZoom = decimal.Parse(x1_RectZoom.Text);
            this.y1_RecZoom = decimal.Parse(y1_RectZoom.Text);
            this.x2_RecZoom = decimal.Parse(x2_RectZoom.Text);
            this.y2_RecZoom = decimal.Parse(y2_RectZoom.Text);
            this.divideHori_RecZoom = Convert.ToInt32(divideHori_RectZoom.Text);
            this.precision_RecZoom = decimal.Parse(precision_RectZoom.Text);
            ///////////////////decimal[,] excelArea =new decimal[]
        }
    }
}

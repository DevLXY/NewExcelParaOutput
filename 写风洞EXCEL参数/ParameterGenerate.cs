using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ParameterGenerate
    {
        public  ParameterGenerate()
        {

        }

        public void OneGenerateRecArea(decimal[] para)
        {
            if (para.Length==6)       //应该是动态数组改为count
            {
                decimal z1 = para[0];
                decimal z2 = para[1];
                decimal x1 = para[2];
                decimal y1 = para[3];
                decimal x2 = para[4];
                decimal y2 = para[5];
                string cellPara = "Z(" + z1 + "," + z2 + ")A(" + x1 + "," + y1 + ")B(" + x2 + "," + y2 + ")";
                //在click中写入excel表格
            }

            if (para.Length == 7)      //水平或者垂直区域，动态数组改为count
            {
                decimal z1 = para[0];
                decimal z2 = para[1];
                decimal x1 = para[2];
                decimal y1 = para[3];
                decimal x2 = para[4];
                decimal y2 = para[5];
                decimal precision =para[6];
                string cellPara = "Z(" + z1 + "," + z2 + ")A(" + x1 + "," + y1 + ")B(" + x2 + "," + y2 + ")" + precision;
                
            }
        }


        //public void oneGenerateCuboid(decimal[] para)
        //{
        //    if (para.Length == 7)
        //    {
        //        decimal x0 = para[0];
        //        decimal y0 = para[0];
        //        decimal z0 = para[0];
        //        decimal x1 = para[0];
        //        decimal y1 = para[0];
        //        decimal x2 = para[0];
        //        decimal z1 = para[0];
        //        //string cellPara = "Z(" + z1 + "," + z2 + ")A(" + x1 + "," + y1 + ")B(" + x2 + "," + y2 + ")" + precision;

        //    }
        //}
    }
}

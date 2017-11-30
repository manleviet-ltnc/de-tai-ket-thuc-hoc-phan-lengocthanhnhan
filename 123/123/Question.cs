using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace _123
{
    class Question
    {
        public int QS{get;}
        public int Da1{get;}
        public int Da2{get;}
        public int Da3{get;}
        public int Dad{get;}
        public Question(int qs, int da1, int da2, int da3, int dad)
        {
            this.QS = qs;
            this.Da1 = da1;
            this.Da2 = da2;
            this.Da3 = da3;
            this.Dad = dad;
        }

       
    }
}

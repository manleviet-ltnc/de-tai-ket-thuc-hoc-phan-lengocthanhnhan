using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _123
{
    public partial class Top10 : Form
    {
       

        public Top10()
        {
            InitializeComponent();
            loadtop();
        }

        public string Top
        {
            set { lblTop.Text = value; }
        }
        public void loadtop()
        {
          
        }
       
    }
}

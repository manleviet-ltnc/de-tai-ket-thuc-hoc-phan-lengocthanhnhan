using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _123
{
    public partial class _123 : Form
    {
        public _123()
        {
            InitializeComponent();
        }


        public string Message
        {

            get { return lblYourScore.Text; }
            set { lblYourScore.Text = value; }
        }


    }

    }


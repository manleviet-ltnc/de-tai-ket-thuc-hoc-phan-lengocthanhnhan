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
    public partial class _123 : Form
    {
        
        public _123()
        {
            InitializeComponent();
            _123_Load();
        }

        public string YourScore
        {
            set { lblYourScore.Text = value; }
        }

        public string BestScore
        {
            set { lblBestScore.Text = value; }
        }



        public void _123_Load(object sender, EventArgs e)
        {
          
        }
       
       

        //public void Save()
        //{
        //    if (yourScore >= bestscore)
        //    {
        //        bestscore = yourScore;
        //        Save(bestscore);
        //    }

        //}
        //public void Save(int bestscore)
        //{
        //    lblBestScore.Text = bestscore.ToString();
        //    Save(bestscore);
        //}

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void lbltop10_Click(object sender, EventArgs e)
        {
            Top10 dlg = new Top10();
            dlg.ShowDialog();
            dlg.Top = "TopScore.txt";
        }

        private void _123_Load()
        {

        }
    }
}
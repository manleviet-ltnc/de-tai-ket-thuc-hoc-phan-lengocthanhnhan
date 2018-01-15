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
            _123_Load();
        }

        int yourScore;
        int bestscore;

        public void _123_Load()
        {
            lblYourScore.Text = yourScore.ToString();
            lblBestScore.Text = bestscore.ToString();
            if (yourScore > bestscore)
            {
                bestscore = yourScore;
                Save();
            }
        }
       
        public string Message
        {
            get { return lblYourScore.Text; }
            set { lblYourScore.Text = value; }
        }
      public void Save()
      {
          if (yourScore >= bestscore)
          {
              bestscore = yourScore;
              Save(bestscore);
          }
         
      }
      public void Save(int bestscore)
      {
          lblBestScore.Text = bestscore.ToString();
          Save(bestscore);
      }

      private void btnRestart_Click(object sender, EventArgs e)
      {
          frm123 frm = new frm123();
          frm.ShowDialog();
      }

      
    
        }
}
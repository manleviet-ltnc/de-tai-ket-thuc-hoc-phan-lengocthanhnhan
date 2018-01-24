using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace _123
{
    public partial class _123 : Form
    {
        Thread thread;
        
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


        private void lbltop10_Click(object sender, EventArgs e)
        {
            Close();
            thread = new Thread(OpenTop);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenTop()
        {
            Application.Run(new Top10());
        }
        private void _123_Load()
        {

        }
    }
}
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
    public partial class frm123 : Form
    {
        public frm123()
        {
            InitializeComponent();
        }

        private void frm123_Load(object sender, EventArgs e)
        {
            List<string> Question = new List<string>();
            using (StreamReader reader = new StreamReader(@"c:\Question.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] delimiters = new char[] { ' ', ' ', ' ', ' ', ' ' };
                    string[] qs = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string st in qs)
                    {
                        lblQuestion.Text = qs[0];
                        btn1.Text = qs[1];
                        btn2.Text = qs[2];
                        btn3.Text = qs[3];

                    }
                }
                reader.Close();
            }
        }
    }
}

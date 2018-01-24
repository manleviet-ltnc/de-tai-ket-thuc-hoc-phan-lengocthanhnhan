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
        Label[] HT = new Label[10];
        Label[] Diem = new Label[10];
       
        List<SCORE> lst = new List<SCORE>();
       
        public Top10()
        {
            InitializeComponent();
           
        }
        

        void LoadLabel()
        {
            HT[1] = lbltop1;
            HT[2] = lbltop2;
            HT[3] = lbltop3;
            HT[4] = lbltop4;
            HT[5] = lbltop5;
            HT[6] = lbltop6;
            HT[7] = lbltop7;
            HT[8] = lbltop8;
            HT[9] = lbltop9;
            HT[10] = lblTop10;

            Diem[1] = lblscore1;
            Diem[2] = lblscore2;
            Diem[3] = lblscore3;
            Diem[4] = lblscore4;
            Diem[5] = lblscore5;
            Diem[6] = lblscore6;
            Diem[7] = lblscore7;
            Diem[8] = lblscore8;
            Diem[9] = lblscore9;
            Diem[10] = lblscore10;
        }

        void Loadtop()
        {
            StreamReader rd = new StreamReader("TopScore.txt");
            string dong;
            while ((dong = rd.ReadLine()) != null)
            {
                char[] delimit = new char[] { '|' };
                string[] sc = dong.Split(delimit, StringSplitOptions.RemoveEmptyEntries);
                SCORE s = new SCORE();
                s.HT =sc[0];
                s.Diem = int.Parse(sc[1]);
                lst.Add(s);
            }
            rd.Close();

        }
        

        void sapxep()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = i + 1; j <= 10; j++)
                {
                    if (lst[i].Diem < lst[j].Diem)
                    {
                        int t = lst[i].Diem;
                        lst[i].Diem = lst[j].Diem;
                        lst[j].Diem = t;
                    }
                    else
                    { break; }
                }
            }
        }

      

        private void Top10_Load(object sender, EventArgs e)
        {
            LoadLabel();
            Loadtop();
            sapxep();
            if (lst.Count() > 10)
                lst.RemoveAt(10);
            StreamWriter sw = null;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    sw = new StreamWriter("TopScore.txt");
                else
                    sw = File.AppendText("TopScore.txt");
                HT[i].Text = lst[i].HT;
                Diem[i].Text = lst[i].Diem + "";
                sw.Close();
            }


        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
            
        
       
    }
}

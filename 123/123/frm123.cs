﻿using System;
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
        List<Question> list = new List<Question>();

        public frm123()
        {
            InitializeComponent();
            Load();
            int index = ChoiceQuestion();

            SetQuestion(index);

        }


        public void SetQuestion(int index)
        {
            Question q = list[index];

            lblQuestion.Text = q.Q;
            btn1.Text = q.DA1;
            btn2.Text = q.DA2;
            btn3.Text = q.DA3;
            if (q.DAD == 1)
            {
                btn1.Tag = true;
                btn2.Tag = false;
                btn3.Tag = false;
            }
            else if (q.DAD == 2)
            {
                btn2.Tag = true;
                btn1.Tag = false;
                btn3.Tag = false;
            }
            else if (q.DAD == 3)
            {
                btn3.Tag = true;
                btn2.Tag = false;
                btn1.Tag = false;
            }



        }

        public void Load()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            StreamReader reader = new StreamReader("Question.txt");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                char[] delimiters = new char[] { '|' };
                string[] qs = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                Question q = new Question();
                q.Q = qs[0];
                q.DA1 = qs[1];
                q.DA2 = qs[2];
                q.DA3 = qs[3];
                q.DAD = int.Parse(qs[4]);

                list.Add(q);
            }

            reader.Close();
        }
        // Chọn ngẫu nhiên
        public int ChoiceQuestion()
        {
            int[] b = new int[25];
            Random r = new Random();
            for (int i = 1; i < 25; i++)
            {
                b[i] = r.Next(25);
                Console.WriteLine("{0}", b[i]);
            }
            Console.ReadLine();

            return r.Next(1, 25);

        }

        int Score;
        private void btn1_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            
                if ((bool)b.Tag == true)
                {
                    Score++;
                    lblScore.Text = Score.ToString();
                    // Thong bao dung
                    // chuyen sang cau khac
                    int index = ChoiceQuestion();

                    SetQuestion(index);
                }
                else
                {
                    _123 dlg = new _123(); //Khởi tạo form _123
                    dlg.Message = lblScore.Text;

                    dlg.ShowDialog();//Hiện form _123 
                }
            
        }

        int time=10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = time.ToString();

            time--;
        }
    }
}
  
        

      

       

  

      
    


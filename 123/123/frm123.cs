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

        }

        public void Load()
        {
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

        public int ChoiceQuestion()
        {
            Random r = new Random();
            return r.Next(1,25);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TranslateEnglish
{
    public partial class TranslateForm : Form
    {
        public TranslateForm()
        {
            InitializeComponent();
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            ITranslator translator;
            if (RbLatin.Checked)
            {
                translator = new PigLatinTranslator();
            }
            else
            {
                translator = new PigGreekTranslator();
            }
            TbOutput.Text = translator.Translate(TbInput.Text);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbInput.Text = null;
            TbOutput.Text = null;
            RbLatin.Checked = true;
            RbGreek.Checked = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

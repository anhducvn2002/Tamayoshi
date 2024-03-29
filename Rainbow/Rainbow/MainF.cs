﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbow
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void btnJYU_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "生産予定入力"))
                Application.OpenForms["生産予定入力"].Hide();
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "一覧確認"))
            {
                Application.OpenForms["一覧確認"].Hide();
            }
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "確定受注入力"))
            {
                Application.OpenForms["確定受注入力"].Show();
                Application.OpenForms["確定受注入力"].Activate();
                if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "図番マスター"))
                {
                    if (Application.OpenForms["図番マスター"].Visible)
                    {
                        Application.OpenForms["図番マスター"].Hide();
                    }
                }
            }
            else
            {
                確定受注入力 f1 = new 確定受注入力();
                f1.StartPosition = FormStartPosition.Manual;

                f1.Show(this);

                if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "図番マスター"))
                {
                    if (Application.OpenForms["図番マスター"].Visible)
                    {
                        Application.OpenForms["図番マスター"].Hide();
                    }
                }
            }
            //this.Close();

        }

        private void btnSEI_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "確定受注入力"))
                Application.OpenForms["確定受注入力"].Hide();
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "一覧確認"))
            {
                Application.OpenForms["一覧確認"].Hide();
            }
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "生産予定入力"))
            {
                Application.OpenForms["生産予定入力"].Show();
                Application.OpenForms["生産予定入力"].Activate();
                if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "図番マスター"))
                {
                    if (Application.OpenForms["図番マスター"].Visible)
                    {
                        Application.OpenForms["図番マスター"].Hide();
                    }
                }
            }
            else
            {
                生産予定入力 f1 = new 生産予定入力();
                f1.StartPosition = FormStartPosition.Manual;

                f1.Show();
                if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "図番マスター"))
                {
                    if (Application.OpenForms["図番マスター"].Visible)
                    {
                        Application.OpenForms["図番マスター"].Hide();
                    }
                }
            }
        }

        /// <summary>
        /// OKしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "設定"))
            {
                Application.OpenForms["設定"].Show();
                Application.OpenForms["設定"].Activate();
            }
            else
            {
                設定 f1 = new 設定();
                f1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "確定受注入力"))
            {
                Application.OpenForms["確定受注入力"].Hide();
            }

            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "生産予定入力"))
            {
                Application.OpenForms["生産予定入力"].Hide();
            }


            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "一覧確認"))
            {
                Application.OpenForms["一覧確認"].Show();
                Application.OpenForms["一覧確認"].Activate();
                if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "図番マスター"))
                {
                    if (Application.OpenForms["図番マスター"].Visible)
                    {
                        Application.OpenForms["図番マスター"].Hide();
                    }
                }
            }
            else
            {
                一覧確認 f1 = new 一覧確認();
                f1.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "Form1"))
            {
                Application.OpenForms["Form1"].Show();
                Application.OpenForms["Form1"].Activate();
            }
            else
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}

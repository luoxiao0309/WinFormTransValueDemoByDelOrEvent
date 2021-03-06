﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmDemo
{
    public partial class ObeserverFormB : Form
    {



        public ObeserverFormB()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 提供外部访问自己元素的方法
        /// </summary>
        /// <param name="txt"></param>
        public void SetText(string txt)
        {
            this.txtMsg.Text = txt;
        }



        internal void MainFormTxtChaned(object sender, EventArgs e)
        {
            //取到主窗体的传来的文本
            MyEventArg arg = e as MyEventArg;
            this.SetText(arg.Text);
        }
    }
}

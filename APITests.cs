﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlueSkyNew.API;

namespace BlueSkyNew
{
    public partial class APITests : Form
    {
        public APITests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rAPI.notice("A hello from the API itself :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rAPI.installmc(progressBar1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int test = rAPI.notice_ask("test", "Press ok for 1, press cancel for 2");
            if (test == 1)
            {
                rAPI.notice("you pressed ok"); 
            }
            else
            {
                rAPI.notice("you pressed cancel");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rAPI.uninstallmc(progressBar1, label2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rAPI.notice("This is a testing GUI to test various BlueSky API functions. This GUI should be only used for testing purposes and may not stable for main usage.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rAPI.launch(11, 0, 45, progressBar1, label2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rAPI.launch(11, 2, 45, progressBar1, label2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rAPI.launch(11, 3, 45, progressBar1, label2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rAPI.ws();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int test = rAPI.checkmc();
            if(test == 1)
            {
                rAPI.notice("not installed");
            }
            else
            {
                rAPI.notice("installed");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rAPI.desvc();
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            string realver = await rAPI.mcver();
            if(realver != null)
            {
                rAPI.notice(realver + " is the installed version!");
            }
            else
            {
                rAPI.notice("Launcher cannot retrive game version! Error Code GAME_VER_REV_FAILED");
            }
        }
    }
}

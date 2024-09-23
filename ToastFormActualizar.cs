﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class ToastFormActualizar : Form
    {
        int toastX, toastY;
        public ToastFormActualizar()
        {
            InitializeComponent();
        }

        private void labelTypeTittle_Click(object sender, EventArgs e)
        {

        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastX = ScreenHeight - this.Height + 70;

            this.Location = new Point(toastX, toastY);
        }

        private void ToastActualizarTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY < 760)
            {
                ToastActualizarTimer.Stop();
                ToastTimerHideActualizar.Start();
            }
        }

        int y = 100;
        private void ToastTimerHideActualizar_Tick(object sender, EventArgs e)
        {
            y--;
            if (y < 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY);
                if (toastY > 800)
                {
                    ToastActualizarTimer.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
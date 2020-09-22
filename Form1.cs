using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BarberoDormilon
{
    public partial class Form1 : Form
    {
        Thread barberShop = null;
        bool work = false;
        bool close = false;
        int unattended = 0;
        int time = 5;
        int[] sits = new int[5];
        
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.pbBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb0.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (barberShop != null) barberShop.Abort();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbxTime.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            time = Int32.Parse(tbxTime.Text);
            barberShop = new Thread(new ThreadStart(start));
            barberShop.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            tbxTime.Enabled = true;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            work = false;
        }

        void start()
        {
            sits[0] = 0;
            sits[1] = 0;
            sits[2] = 0;
            sits[3] = 0;
            sits[4] = 0;

            work = true;

            while (work)
            {
                addClient();
                cortarPelo();
                validaEstadoBarbero();
                Thread.Sleep(time*1000);
            }

        }

        void addClient()
        {
            Random rnd = new Random();
            int cliente = close ? 0 : rnd.Next(0, 2);
            for (int i = 0; i < sits.Length - 1; i++)
            {
                //asiento #i
                if (sits[i] == 0)
                {
                    sits[i] = sits[i + 1];
                    sits[i + 1] = 0;
                }

            }
            if (sits[sits.Length - 1] == 0)
            {
                sits[sits.Length - 1] = cliente;
            }
            else
            {
                unattended += cliente;
            }
            validarImg();
            lblClientsNo.Text = unattended + "";
        }
        
        void validarImg() {
            if (sits[0] == 1) {
                pb0.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\filled.png");
            }
            else {
                pb0.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\available.png");
            }
            if (sits[1] == 1)
            {
                pb1.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\filled.png");
            }
            else
            {
                pb1.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\available.png");
            }
            if (sits[2] == 1)
            {
                pb2.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\filled.png");
            }
            else
            {
                pb2.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\available.png");
            }
            if (sits[3] == 1)
            {
                pb3.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\filled.png");
            }
            else
            {
                pb3.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\available.png");
            }
            if (sits[4] == 1)
            {
                pb4.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\filled.png");
            }
            else
            {
                pb4.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\available.png");
            }
        }

        void cortarPelo()
        {
            if (sits[0] == 1 && time == 5)
            {
                --time;
                sits[0] = 0;
            }
            else if (time < 5 && time > 0) {
                --time;
            }
            else if (time == 0) {
                time = 5;
            }
        }

        void validaEstadoBarbero()
        {
            if (time == 5)
            {
                bool alone = true;

                for (int i = 0; i < sits.Length; i++)
                {
                    if (sits[i] == 1)
                    {
                        alone = false;

                        break;
                    }

                }

                if (pbBarber.Image == Image.FromFile("C:\\git\\BarberoDormilon\\res\\empty.png"))
                {
                    pbBarber.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\sleep.png");
                }
                else
                {
                    pbBarber.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\awake.png");
                }
            }
            else
            {
                pbBarber.Image = Image.FromFile("C:\\git\\BarberoDormilon\\res\\work.png");
            }
        }

        private void BtnOpenDoor_Click(object sender, EventArgs e)
        {
            btnCloseDoor.Enabled = true;
            btnOpenDoor.Enabled = false;
            close = false;
            work = true;
        }

        private void BtnCloseDoor_Click(object sender, EventArgs e)
        {
            btnOpenDoor.Enabled = true;
            btnCloseDoor.Enabled = false;
            work = false;
            close = true;
        }
    }
}

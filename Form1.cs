using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_telefonico
{
    public partial class Form1 : Form
    {

        int numero;

        public Form1()
        {
            InitializeComponent();
        }

        private void mostra()
        {
            Console.Beep();
            label1.Text = numero.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int valor = 0;
            switch(((Button)sender).Name)
                {
                case "button1": valor = 1; break;
                case "button2": valor = 2; break;
                case "button3": valor = 3; break;
                case "button4": valor = 4; break;
                case "button5": valor = 5; break;
                case "button6": valor = 6; break;
                case "button7": valor = 7; break;
                case "button8": valor = 8; break;
                case "button9": valor = 9; break;
                case "button10": valor = 0; break;
            }
            if (numero.ToString().Length < 9)
                numero = numero * 10 + valor;
            mostra();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            numero = numero * 10 + 2;
            mostra();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numero = numero * 10 + 3;
            mostra();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numero = 0;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer pal = new System.Media.SoundPlayer(Numero_telefonico.Properties.Resources.Som_Chamada_de_Ligação_Audio_Telefone_Ligando);
            label1.Text = "";
            numero = 0;
            mostra();
            label4.Visible = false;
            pal.Stop();

            if (label5.Visible == true)
            {
                label5.Visible = false;
                label1.Visible = true;
                label1.Text = "";
                numero = 0;
                mostra();
            }

            if (label6.Visible == true)
            {
                label6.Visible = false;
                label1.Visible = true;
                label1.Text = "";
                numero = 0;
                mostra();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer pal = new System.Media.SoundPlayer(Numero_telefonico.Properties.Resources.Som_Chamada_de_Ligação_Audio_Telefone_Ligando);
            pal.Play();

            label4.Visible = true;

            if (label1.Text == "123")
            {
                label5.Visible = true;
                label4.Visible = false;
                System.Media.SoundPlayer palsaldo = new System.Media.SoundPlayer(Numero_telefonico.Properties.Resources.Som_de_notificação_Moto_X);
                palsaldo.Play();
            }

            if (label1.Text == "935948337")
            {
                System.Media.SoundPlayer palchamada = new System.Media.SoundPlayer(Numero_telefonico.Properties.Resources.Telefonema_para_a_NOS);
                palchamada.Play();
                label4.Visible = false;
                label6.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuperSocket;
using SuperWebSocket;

namespace Chatcliente_servidor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            int puerto = 8088;
            InitializeComponent();
            Console.WriteLine("Se ha iniciado el servidor en el puerto" + puerto + "Presiona S para Continuar");
            while (Console.ReadKey().Key != ConsoleKey.S) ;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Hay una nueva conexion en el servidor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtUsuario.Text + txtdato.Text);
            //Console.WriteLine("El usuario; {0}", txtdato.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("El usuario ha cerrado la sesion");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMensaje.Clear();
            txtdato.Clear();
            txtUsuario.Clear();
            Console.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine("Servidor.Respuesta");
            string msg = Console.ReadLine();
            txtMensaje.Text = msg;
            this.Show();
        }
    }
}
       
        
        

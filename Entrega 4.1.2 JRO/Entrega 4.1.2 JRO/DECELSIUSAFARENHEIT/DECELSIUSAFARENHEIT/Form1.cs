using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
         private void button1_Click(object sender, EventArgs e)
        {

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("10.0.3.15");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(ipep);//Intentamos conectar el socket
            this.BackColor = Color.Green;

            if (celtofar.Checked)
            {
                 // Quiere saber la longitud
                string mensaje = "1/" + grados.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("Tu temperatura en Farenheit es: " + mensaje);
            }
            else if (fartocel.Checked)
            {
                    // Quiere saber si el nombre es bonito
                string mensaje = "2/" + grados.Text;
                    // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                    //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("Tu temperatura en Farenheit es: " + mensaje);


            }
              // Se terminó el servicio. 
            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();



}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduino
{
    public partial class Form1 : Form
    {
        SerialPort conexao = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            
        }

        private void atualizaListaCOMs()
        {
            int i = 0; //se a quantidade de portas mudou
            bool quantDiferente = false;    //flag para sinalizar que a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCom_Tick(object sender, EventArgs e)
        {            
            atualizaListaCOMs();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conexao.IsOpen == true)  // se porta aberta
                conexao.Close();        	//fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (!conexao.IsOpen)
            {               
                conexao.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                conexao.BaudRate = 9600;
                conexao.Open();
                conexao.Write(textBoxEnviar.Text);
                conexao.Close();
            }

            if (conexao.IsOpen)
            {
                comboBox1.Enabled = false;               
            }
        }
        string RxString;
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }

        private void conexao_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {            
            RxString = conexao.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
           
        }

        private void btConenctar_Click(object sender, EventArgs e)
        {
            if (!conexao.IsOpen)
            {
                textBoxReceber.Clear();
                comboBox1.Enabled = false;
                conexao.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                conexao.BaudRate = 9600;
                btConenctar.Text = "Desconectar";
                conexao.DataReceived += new SerialDataReceivedEventHandler(conexao_DataReceived);
                conexao.Open();
            }else
            {
                comboBox1.Enabled = true;
                btConenctar.Text = "Conectar";
                conexao.Close();
            }

        }
    }
}


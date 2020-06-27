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

namespace Auto_Irrigation
{
    public partial class main_page : Form
    {
        private SerialPort myport;
        private String in_data_moisture;
        private String in_data_water;
        private String in_data_temperature;
        public main_page()
        {
            InitializeComponent();
            serial();
        }
        private void serial()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM3";
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.DataReceived += myport_DataReceived;
                myport.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data_moisture = myport.ReadLine();
            this.Invoke(new EventHandler(display_event));

        }

        private void display_event(object sender, EventArgs e)
        {
            
            moisture_per.Text = in_data_moisture;
            int data_moisture_value = Convert.ToInt32(in_data_moisture);
            moisture_bar.Value =data_moisture_value ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void moisture_per_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

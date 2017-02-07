using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace snif
{
    public partial class Form1 : Form
    {
        private long packetCounter = 0;
        private long packetDelta = 0;
        private long packetTotal = 0;

        NetworkInterface selectedNetworkInterface;

        private void InitializeComboBox()
        {
            NetworkInterface[] ntIfaces = NetworkInterface.GetAllNetworkInterfaces();

            if ((ntIfaces == null)||(ntIfaces.Length < 1))
            {
                MessageBox.Show("Here is no any network interface...");
                return;
            }
            
            cntIface.Text = "( "+ntIfaces.Length.ToString()+" )";
            
            foreach( NetworkInterface iface in ntIfaces)
            {
                cbx_iface.Items.Add(iface.Name);
            }
        }

        private void GetNetworkInterfaceByName()
        {
            NetworkInterface[] ntIfs = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface iface in ntIfs) {
                if (iface.Name == cbx_iface.SelectedItem.ToString())
                    selectedNetworkInterface = iface;
            }            
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();

            InitializeComboBox();

            InitializeTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long packetsRecieved = selectedNetworkInterface.GetIPStatistics().UnicastPacketsReceived;
            packetCounter += packetsRecieved - packetDelta;
            packetTotal = packetsRecieved;
            packetDelta = packetsRecieved;
            cntIface.Text = packetCounter.ToString();
            cntAll.Text = packetTotal.ToString();
        }

        private void startStop_Click(object sender, EventArgs e)
        {
            if (cbx_iface.SelectedItem == null)
            {
                MessageBox.Show("Please, select network interface...");
                return;
            }
            if ((!timer1.Enabled))
            {
                GetNetworkInterfaceByName();
                packetDelta = selectedNetworkInterface.GetIPStatistics().UnicastPacketsReceived;
                timer1.Enabled = true;
                cbx_iface.Enabled = false;
                btn_startStop.Text = "STOP";
            }
            else
            {
                timer1.Enabled = false;
                cbx_iface.Enabled = true;
                btn_startStop.Text = "START";
            }
        }
    }
}

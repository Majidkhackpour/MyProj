using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_BAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GSMSMSEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void SelectDeviceButton_Click(object sender, EventArgs e)
        {
            MS_SMS.MS_SMS_BAN  MS_I1 = new MS_SMS.MS_SMS_BAN();
            SelectDeviceEdit.Text = MS_I1.SMS_Select_Device(1);
            // IsDisposed = true;
            ((IDisposable)MS_I1).Dispose();
            GC.SuppressFinalize(MS_I1);
            //Dispose(true);
            //GC.SuppressFinalize(this);
            //this.Dispose();
            //sender.Dispose();
            //disposed = true;
            // Call base class implementation.
            base.Dispose(true);
            // Dispose(MS_I1);
        }

        private void SearchDevicesButton_Click(object sender, EventArgs e)
        {
            MS_SMS.MS_SMS_BAN MS_I1 = new MS_SMS.MS_SMS_BAN();


             NumberOfDevicesEdit.Text = Convert.ToString(MS_I1.SMS_Device_Count());
        }

        private void ConnectModemButton_Click(object sender, EventArgs e)
        {

        }
    }
}














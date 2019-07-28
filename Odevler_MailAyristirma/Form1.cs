using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odevler_MailAyristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Mails = { };
        private void BtnMailEkle_Click(object sender, EventArgs e)
        {
            Mails = txtMailEkle.Text.Split(',',';');
            txtMailEkle.Clear();
        }

        private void BtnMailAyristir_Click(object sender, EventArgs e)
        {
            foreach (string item in Mails)
            {
                if (item.EndsWith("tr"))
                {
                    if (item.Contains("hotmail.com"))
                    {
                        lstHotmailcomtr.Items.Add(item);
                    }
                    else if (item.Contains("gmail.com"))
                    {
                        lstGmailComtr.Items.Add(item);
                    }
                }
                else if (item.Contains(".net"))
                {
                    if (item.Contains("hotmail"))
                    {
                        lstHotmailNet.Items.Add(item);
                    }
                    else if (true)
                    {
                        lstGmailNet.Items.Add(item);
                    }                    
                }
                else
                {
                    if (item.Contains("hotmail.com"))
                    {
                        lstHotmailcom.Items.Add(item);
                    }
                    else if (item.Contains("gmail.com"))
                    {
                        lstGmailCom.Items.Add(item);
                    }
                    else
                    {
                        lstCop.Items.Add(item);
                    }
                }
            }
            lblCop.Text = lstCop.Items.Count.ToString();
            lblGmailcom.Text = lstGmailCom.Items.Count.ToString();
            lblGmailComtr.Text = lstGmailComtr.Items.Count.ToString();
            lblGmailNet.Text = lstGmailNet.Items.Count.ToString();
            lblHotmailcom.Text = lstHotmailcom.Items.Count.ToString();
            lblHotmailcomtr.Text = lstHotmailcomtr.Items.Count.ToString();
            lblHotmailnet.Text = lstHotmailNet.Items.Count.ToString();
        }
    }
}

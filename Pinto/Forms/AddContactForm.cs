﻿using PintoNS.Forms.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class AddContactForm : Form
    {
        private MainForm mainForm;

        public AddContactForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactName.Text))
            {
                NotificationUtil.ShowNotification(this, "Invalid username!", "Error", NotificationIconType.ERROR);
                return;
            }
            Close();
            mainForm.NetManager.NetHandler.SendAddContactPacket(txtContactName.Text);
        }
    }
}
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            var products = new List<string>() { "Celular", "Televisor", "Computadora", "Tablet", "Monitor" };
            
            orderId.Text = (Program.getApp().listCount() + 1).ToString();
            entryDate.Text = (DateTime.Now).ToString("dd/MM/yyyy");
   
            foreach (string product in products)
            {
                productType.Items.Add(product);   
            }
            productType.SelectedIndex = 0;


            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(description.Text.Length > 1)
            {
                var id = int.Parse(orderId.Text);
                Program.getApp().addOrder(id, entryDate.Text, productType.Text, description.Text);
                MessageBox.Show(string.Format("Orden cargada con éxito! \n\nOrden ID: {0}", id), "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Visible = false;        
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

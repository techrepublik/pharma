﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaPos.forms;

namespace PharmaPos
{
    public partial class MainForm : Form
    {
        private PreferencesForm _preferencesForm;
        private SupplierListForm _supplierListForm;
        private ProductListForm _productListForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _preferencesForm = new PreferencesForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };
            _preferencesForm.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _supplierListForm = new SupplierListForm
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _supplierListForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _productListForm = new ProductListForm
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _productListForm.Show();
        }
    }
}

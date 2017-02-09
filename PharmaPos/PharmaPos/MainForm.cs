using System;
using System.Windows.Forms;
using PharmaPos.data;
using PharmaPos.forms;

namespace PharmaPos
{
    public partial class MainForm : Form
    {
        public User User { get; set; }

        private PreferencesForm _preferencesForm;
        private SupplierListForm _supplierListForm;
        private ProductListForm _productListForm;
        private CustomerListForm _customerListForm;
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

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UserManagementForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };
            f.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitStatusBar();
        }

        private void InitStatusBar()
        {
            if (User == null) return;
            toolStripStatusLabelUser.Text = String.Format("{0}", User.UserFullName.ToUpper());
            switch (User.UserLevel)
            {
                case 1:
                    maintenanceToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    userToolStripMenuItem.Enabled = false;
                    transactionToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    maintenanceToolStripMenuItem.Enabled = true;
                    userToolStripMenuItem.Enabled = true;
                    transactionToolStripMenuItem.Enabled = true;
                    break;
            }

            toolStripStatusLabelDateTime.Text = DateTime.Now.ToLongDateString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            if (MessageBox.Show(@"Are you sure want close the application?",
                @"PDS System",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
            else
                e.Cancel = true; // to don't close form is user change his mind
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3_Click(sender, e);
        }

        private void toolStripButtonSupplier_Click(object sender, EventArgs e)
        {
            supplierToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonPreferences_Click(object sender, EventArgs e)
        {
            preferencesToolStripMenuItem_Click(sender, e);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _customerListForm = new CustomerListForm
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            _customerListForm.Show();
        }

        private void toolStripButtonCustomer_Click(object sender, EventArgs e)
        {
            customerToolStripMenuItem_Click(sender, e);
        }
    }
}

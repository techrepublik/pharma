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
            if (User != null)
            {
                toolStripStatusLabelUser.Text = String.Format("{0}", User.UserFullName.ToUpper());
            }
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
    }
}

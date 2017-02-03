using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPos.forms
{
    public partial class PreferencesForm : Form
    {

        enum Tabs
        {
            category,
            unit,
            drugType,
            packing,
            voidReason
        }

        Tabs _tabChoice;
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {

        }
    }
}

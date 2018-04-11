using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace OpenTT
{
    public partial class MainForm : Form
    {
        Station from;
        Station to;
        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods

        

        #endregion

        #region Events
        private void btnSearchFrom_Click(object sender, EventArgs e)
        {
            StationSelection selectForm = new StationSelection(txtFrom.Text);
            selectForm.ShowDialog();
            from = selectForm.SelectedStation;
            txtFrom.Text = from.Name;
        }

        private void btnSearchTo_Click(object sender, EventArgs e)
        {
            StationSelection selectForm = new StationSelection(txtTo.Text);
            selectForm.ShowDialog();
            to = selectForm.SelectedStation;
            txtTo.Text = to.Name;
        }

        

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            btnSearchFrom.Enabled = (!string.IsNullOrEmpty(txtFrom.Text));
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            btnSearchTo.Enabled = (!string.IsNullOrEmpty(txtTo.Text));
        }

        #endregion

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            //TODO: Suche
        }
    }
}

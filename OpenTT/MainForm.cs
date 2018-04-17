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
        BindingList<Connection> connectionList = new BindingList<Connection>();

        public MainForm()
        {
            InitializeComponent();
            dgfTimeTable.DataSource = connectionList;
        }

        #region Methods

        private void getTimetable(string from, string to)
        {
            Transport qry = new Transport();
            genBindinglist(qry.GetConnections(from, to));
        }
        private void genBindinglist(Connections connections)
        {
            connectionList.Clear();
            foreach (Connection connection in connections.ConnectionList)
            {
                connectionList.Add(connection);
            }
        }

        private string searchStation(string stationToFind)
        {
            StationSelection selectForm;
            Station resultStation;
            selectForm = new StationSelection(stationToFind);
            selectForm.ShowDialog();

            if (!selectForm.Error)
            {
                resultStation = selectForm.SelectedStation;
                return resultStation.Name;
            }
            else
            {
                MessageBox.Show("Keine Station unter diesem Namen gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        #endregion

        #region Events
        private void btnSearchFrom_Click(object sender, EventArgs e)
        {
            txtFrom.Text = searchStation(txtFrom.Text);
        }

        private void btnSearchTo_Click(object sender, EventArgs e)
        {
            txtTo.Text = searchStation(txtTo.Text);
        }

        

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            btnSearchFrom.Enabled = (!string.IsNullOrEmpty(txtFrom.Text));
            btnSearchConnections.Enabled = (!string.IsNullOrWhiteSpace(txtFrom.Text) &&
                                            !string.IsNullOrWhiteSpace(txtTo.Text));
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            btnSearchTo.Enabled = (!string.IsNullOrEmpty(txtTo.Text));
            btnSearchConnections.Enabled = (!string.IsNullOrWhiteSpace(txtFrom.Text) &&
                                            !string.IsNullOrWhiteSpace(txtTo.Text));
        }

        #endregion

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            getTimetable(txtFrom.Text, txtTo.Text);
        }

    }
}

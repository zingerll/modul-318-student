// Comment
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
        BindingList<StationBoard> StationBoardList = new BindingList<StationBoard>();
        

        public MainForm()
        {
            InitializeComponent();
            dgfTimeTable.DataSource = connectionList;
        }

        #region Methods

        private void getTimetable(string from, string to)
        {
            Transport qry = new Transport();
            connectionList = new BindingList<Connection>(qry.GetConnections(from, to).ConnectionList);
            dgfTimeTable.DataSource = connectionList;
        }

        private void getStationBoard(string station)
        {
            Transport qry = new Transport();
            StationBoardList = new BindingList<StationBoard>(qry.GetStationBoard(station, "0").Entries);
            dgfTimeTable.DataSource = StationBoardList;
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
            btnSearchFrom.Enabled = (!string.IsNullOrWhiteSpace(txtFrom.Text));
            enableSearchConnection();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            btnSearchTo.Enabled = (!string.IsNullOrWhiteSpace(txtTo.Text));
            enableSearchConnection();
        }

        private void enableSearchConnection()
        {
            if (rbConnections.Checked)
            {
                btnSearchConnections.Enabled = (!string.IsNullOrWhiteSpace(txtFrom.Text) &&
                                                    !string.IsNullOrWhiteSpace(txtTo.Text));
            }
        }

        #endregion

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (rbConnections.Checked)
                getTimetable(txtFrom.Text, txtTo.Text);
            else
                getStationBoard(txtFrom.Text);
        }

        private void rbStationBoard_Click(object sender, EventArgs e)
        {
            txtTo.Enabled = false;
            btnSearchTo.Enabled = false;
            lblFrom.Text = "Station";
            btnSearchConnections.Enabled = true;
        }

        private void rbConnections_Click(object sender, EventArgs e)
        {
            txtTo.Enabled = true;
            btnSearchTo.Enabled = (!string.IsNullOrWhiteSpace(txtTo.Text));
            lblFrom.Text = "Von";
            btnSearchConnections.Enabled = (!string.IsNullOrWhiteSpace(txtTo.Text));
        }

        private void txtFrom_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnSearchFrom;
        }

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnSearchConnections;
        }

        private void dgfTimeTable_DataSourceChanged(object sender, EventArgs e)
        {
            dgfTimeTable.Columns[0].Width = 150;
            dgfTimeTable.Columns[1].Width = 150;
            dgfTimeTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

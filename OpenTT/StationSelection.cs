using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTT
{
    public partial class StationSelection : Form
    {
        public const int NumberOfStations = 4;

        bool _error = false;
        public Station SelectedStation
        {
            get;
            private set;
        }

        public bool Error
        {
            get
            {
                return _error;
            }

            set
            {
                _error = value;
            }
        }

        BindingList<Station> stationList = new BindingList<Station>();
        public StationSelection()
        {
            InitializeComponent();
        }
        public StationSelection(string stationToFind)
        {
            InitializeComponent();
            if (searchStation(stationToFind))
            {
                libStationList.DataSource = stationList;
                libStationList.DisplayMember = "Name";
                SelectedStation = stationList[0];
            }
            else
            {
                _error = true;
            }
        }

        private bool searchStation(string stationToFind)
        {
            Transport qry = new Transport();
            genBindinglist(qry.GetStations(stationToFind));
            return (stationList.Count > 1);

        }

        private void genBindinglist(Stations stations)
        {
            foreach (Station station in stations.StationList)
            {
                stationList.Add(station);
                if(stationList.Count >= NumberOfStations) break;
            }
        }

        private void btnSelectStation_Click(object sender, EventArgs e)
        {
            SelectedStation = (Station)libStationList.SelectedItem;
            this.Close();
        }

        private void libStationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelectStation.Enabled = true;
        }

        private void StationSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

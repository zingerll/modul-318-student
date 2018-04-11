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
        public Station SelectedStation
        {
            get;
            private set;
        }

        public const int NumberOfStations = 4;
        BindingList<Station> stationList = new BindingList<Station>();
        public StationSelection()
        {
            InitializeComponent();
        }
        public StationSelection(string stationToFind)
        {
            InitializeComponent();
            searchStation(stationToFind);
            libStationList.DataSource = stationList;
            libStationList.DisplayMember = "Name";
        }

        private void searchStation(string stationToFind)
        {
            Transport qry = new Transport();
            genBindinglist(qry.GetStations(stationToFind));
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
    }
}

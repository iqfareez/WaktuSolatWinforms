using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WaktuSolatWinforms
{
    public partial class Form1 : Form
    {
        private List<JakimLocation> _jakimLocations;
        public Form1()
        {
            InitializeComponent();
            
            PopulateNegeriDropdown();
        }

        private async void PopulateNegeriDropdown()
        {
            _jakimLocations = await ApiFetcher.getLocationData();
            
            negeriComboBox.Items.Clear();
            
            // Add all negeri to the dropdown
            var negeris = _jakimLocations.Select(e => e.negeri).ToHashSet().ToArray();
            negeriComboBox.Items.AddRange(negeris);
        }

        private async void button1_Click(object sender, EventArgs e) 
        {
            // get current date 
            int today = DateTime.Now.Day;
            
            string selectedZone;
            
            // get zone from dropdown
            try
            {
                selectedZone = daerahComboBox.SelectedItem.ToString().Split('-')[0].Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No daerah selected yet");
                return;
            }
            
            
            try
            {
                var res = await ApiFetcher.getPrayerTime(selectedZone);
                 var data = new Dictionary<string, string>
                 {
                     { "Imsak", res.prayerTime[today].imsak },
                     { "Subuh", res.prayerTime[today].fajr },
                     { "Syuruk", res.prayerTime[today].syuruk },
                     { "Zohor", res.prayerTime[today].dhuhr },
                     { "Asar", res.prayerTime[today].asr },
                     { "Maghrib", res.prayerTime[today].maghrib },
                     { "Isha", res.prayerTime[today].isha }
                 };
                 
                 // update zone
                 zoneLabel.Text = res.zone;

                 // Clear existing rows in the DataGridView
                 prayerGridView.Rows.Clear();

                 // Add the data dictionary as rows to the DataGridView
                 foreach (var pair in data)
                 {
                     prayerGridView.Rows.Add(pair.Key, pair.Value);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            // show current time
            dateLabel.Text = DateTime.Now.ToString("D");
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt zz");
        }

        private void negeriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNegeri = negeriComboBox.SelectedItem.ToString();
            
            daerahComboBox.Items.Clear();
            
            // Add all daerah to the dropdown

            var daerahs = _jakimLocations.Where(data => data.negeri == selectedNegeri).ToArray();
            // var daerahs = _jakimLocations.Where(data => data.negeri == selectedNegeri).Select(negeriData => negeriData.daerah).ToHashSet().ToArray();
            foreach (var item in daerahs)
            {
                daerahComboBox.Items.Add($"{item.jakimCode} - {item.daerah}");
            }
        }
    }
}
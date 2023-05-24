using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WaktuSolatWinforms
{
    public class PrayerTime
    {
        public string hijri { get; set; }
        public string date { get; set; }
        public string day { get; set; }
        public string imsak { get; set; }
        public string fajr { get; set; }
        public string syuruk { get; set; }
        public string dhuhr { get; set; }
        public string asr { get; set; }
        public string maghrib { get; set; }
        public string isha { get; set; }
    }

    public class WaktuSolat
    {
        public List<PrayerTime> prayerTime { get; set; }
        public string status { get; set; }
        public string serverTime { get; set; }
        public string periodType { get; set; }
        public string lang { get; set; }
        public string zone { get; set; }
        public string bearing { get; set; }
    }
    
    public class JakimLocation
    {
        public string jakimCode { get; set; }
        public string negeri { get; set; }
        public string daerah { get; set; }
    }


    public class ApiFetcher
    {
        public static async Task<WaktuSolat> getPrayerTime(string jakimZone)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://mpt-server.vercel.app/api/solat/{jakimZone}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                WaktuSolat myDeserializedClass = JsonConvert.DeserializeObject<WaktuSolat>(result);
                return myDeserializedClass;
            }
        }
        
        public static async Task<List<JakimLocation>> getLocationData()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://mpt-server.vercel.app/api/zones";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                
                var locationList = JsonConvert.DeserializeObject<List<JakimLocation>>(result);
                

                // JakimLocation myDeserializedClass = JsonConvert.DeserializeObject<JakimLocation>(result);
                return locationList;
            }
        }
    }
}
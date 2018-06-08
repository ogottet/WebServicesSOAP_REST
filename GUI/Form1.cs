using BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {

        static string baseUri = "http://153.109.124.35:81/tef-rest/api/";
        public Form1()
        {
            InitializeComponent();
            fillCbCardIDs();
            fillCbUsernames();
            fillCbUserIDs();
            fillTfUserData();
            fillTfCardData();
            InitTimer();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillTfCardData();
            fillTfUserData();
            lInfo.Text = "The data refreshes automatically every 2 seconds. \nLast refresh was at " + GetTimestamp(DateTime.Now);
        }

        void fillCbCardIDs()
        {
            List<int> cids = new List<int>();

            string uri = baseUri + "cardids";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                cids = JsonConvert.DeserializeObject<List<int>>(response.Result);
            }

            for (int i = 0; i < cids.Count; i++)
            {
                cbCardIDs.Items.Add(cids[i]);
            }
        }

        void fillCbUserIDs()
        {
            List<int> cids = new List<int>();

            string uri = baseUri + "userids";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                cids = JsonConvert.DeserializeObject<List<int>>(response.Result);
            }

            for (int i = 0; i < cids.Count; i++)
            {
                cbUserIDs.Items.Add(cids[i]);
            }
        }

        void fillCbUsernames()
        {
            List<string> cids = new List<string>();

            string uri = baseUri + "usernames";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                cids = JsonConvert.DeserializeObject<List<string>>(response.Result);
            }

            for (int i = 0; i < cids.Count; i++)
            {
                cbUsernames.Items.Add(cids[i]);
            }
        }

        void fillTfUserData()
        {
            List<Dictionary<string,object>> cids = new List<Dictionary<string, object>>();

            string uri = baseUri + "userstable";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                cids = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(response.Result);
            }

            DataTable data = new DataTable("Users");

            for (int i = 0; i < cids.Count; i++)
            {
                DataRow drRow = data.NewRow();

                foreach (KeyValuePair<string, object> col in cids[i])
                {
                    if (i == 0)
                    {
                        DataColumn dcCol = new DataColumn(col.Key);
                        data.Columns.Add(dcCol);
                    }

                    drRow[col.Key] = col.Value;
                }

                data.Rows.Add(drRow);
            }
            dgvUsers.DataSource = data;
        }

        void fillTfCardData()
        {
            List<Dictionary<string, object>> cids = new List<Dictionary<string, object>>();

            string uri = baseUri + "cardstable";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                cids = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(response.Result);
            }

            DataTable data = new DataTable("Cards");

            for (int i = 0; i < cids.Count; i++)
            {
                DataRow drRow = data.NewRow();

                foreach (KeyValuePair<string, object> col in cids[i])
                {
                    if (i == 0)
                    {
                        DataColumn dcCol = new DataColumn(col.Key);
                        data.Columns.Add(dcCol);
                    }

                    drRow[col.Key] = col.Value;
                }

                data.Rows.Add(drRow);
            }
            dgvCards.DataSource = data;
        }

        private void btRechargeByUserID_Click(object sender, EventArgs e)
        {
            PrintCardServiceSOAP.PrintCardServiceClient client = new PrintCardServiceSOAP.PrintCardServiceClient();
            client.RechargeByUserId(Int32.Parse(cbUserIDs.SelectedItem.ToString()), Convert.ToDouble(cbAmountByUserID.SelectedItem));
        }

        private void btRechargeByUsername_Click(object sender, EventArgs e)
        {
            PrintCardServiceSOAP.PrintCardServiceClient client = new PrintCardServiceSOAP.PrintCardServiceClient();
            client.RechargeByUserName(cbUsernames.SelectedItem.ToString(), Convert.ToDouble(cbAmoutByUsername.SelectedItem));
        }

        private void btRechargeByCardID_Click(object sender, EventArgs e)
        {
            PrintCardServiceSOAP.PrintCardServiceClient client = new PrintCardServiceSOAP.PrintCardServiceClient();
            client.RechargePrinterQuota(Int32.Parse(cbCardIDs.SelectedItem.ToString()),Convert.ToDouble(cbAmountByCardID.SelectedItem));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillTfCardData();
            fillTfUserData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TestingSteamAPIFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (steamapikey.Text != null & steamid64.Text != null)
            {
                string rawjson = (new WebClient()).DownloadString("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + steamapikey.Text + "&steamids=" + steamid64.Text);
                var array = JsonConvert.DeserializeObject<RootObject>(rawjson);
                RawJSONTextBox.Text = rawjson;
                usernamelabel.Text = "Username: " + array.response.players[0].personaname;
                urllabel.Text = "url: " + array.response.players[0].profileurl;
                pictureBox1.Load(array.response.players[0].avatarfull);
                namelabel.Text = "Name: " + array.response.players[0].realname;
            }
        }
    }
    public class Player
    {
        public string steamid { get; set; }
        public int communityvisibilitystate { get; set; }
        public int profilestate { get; set; }
        public string personaname { get; set; }
        public int lastlogoff { get; set; }
        public string profileurl { get; set; }
        public string avatar { get; set; }
        public string avatarmedium { get; set; }
        public string avatarfull { get; set; }
        public int personastate { get; set; }
        public string realname { get; set; }
        public string primaryclanid { get; set; }
        public int timecreated { get; set; }
        public int personastateflags { get; set; }
        public string loccountrycode { get; set; }
        public string locstatecode { get; set; }
        public int loccityid { get; set; }
    }

    public class Response
    {
        public List<Player> players { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
    }
}

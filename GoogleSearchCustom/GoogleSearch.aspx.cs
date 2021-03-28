using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleSearchCustom
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int dem = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnNextPage.Visible = false;
            btnPrePage.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyWord.Text != String.Empty)
            {
                var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=AIzaSyCbNot3KrQL719K-9DD5Zuzw-ogz_HJ1qM&cx=f8e752bbba9848d6c&q=" + txtKeyWord.Text);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseString = reader.ReadToEnd();
                dynamic jsonData = JsonConvert.DeserializeObject(responseString);
                var results = new List<Models.Result>();
                string s = "<p class='count'>Khoảng " + jsonData.searchInformation.formattedTotalResults + " kết quả (" + jsonData.searchInformation.formattedSearchTime + ") giây</p>";
                foreach (var item in jsonData.items)
                {

                    s += "<table id='daylabangne'><tr><td class='tddisplaylink'>" + item.displayLink + " " + @"<i class='fas fa-angle-down' style='font-size:13px;'></i>" + "</td></tr>";

                    s += "<tr><td class='tdlink'>" + "<a href=" + item.link + @">" + item.title + @"</a>" + "</td></tr>";
                    try
                    {
                        s += "<tr style='display: flex;flex-direction: row;'><td><img width='100px'; src='" + item.pagemap.cse_thumbnail[0].src + "'></td><td class='tdsnippet'>" + item.snippet + "</td></tr> </table><br>";
                    }
                    catch (Exception ex)
                    {

                    }
                }
                lbResult.Text = s;
                btnNextPage.Visible = true;
            }
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            dem = dem + 10;
            var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=AIzaSyCbNot3KrQL719K-9DD5Zuzw-ogz_HJ1qM&cx=f8e752bbba9848d6c&q=" + txtKeyWord.Text + "&start=" + dem);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            var results = new List<Models.Result>();
            string s = "<p class='count'>Khoảng " + jsonData.searchInformation.formattedTotalResults + " kết quả (" + jsonData.searchInformation.formattedSearchTime + ") giây</p>";
            foreach (var item in jsonData.items)
            {

                s += "<table id='daylabangne'><tr><td class='tddisplaylink'>" + item.displayLink + " " + @"<i class='fas fa-angle-down' style='font-size:13px;'></i>" + "</td></tr>";

                s += "<tr><td class='tdlink'>" + "<a href=" + item.link + @">" + item.title + @"</a>" + "</td></tr>";
                try
                {
                    s += "<tr style='display: flex;flex-direction: row;'><td><img width='100px'; src='" + item.pagemap.cse_thumbnail[0].src + "'></td><td class='tdsnippet'>" + item.snippet + "</td></tr> </table><br>";
                }
                catch (Exception ex)
                {

                }
            }
            lbResult.Text = s;
            btnNextPage.Visible = true;
            if (dem > 100)
            {
                btnNextPage.Visible = false;
            }
            btnPrePage.Visible = true;
        }

        protected void btnPrePage_Click(object sender, EventArgs e)
        {
            dem = dem - 10;
            var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=AIzaSyCbNot3KrQL719K-9DD5Zuzw-ogz_HJ1qM&cx=f8e752bbba9848d6c&q=" + txtKeyWord.Text + "&start=" + dem);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            var results = new List<Models.Result>();
            string s = "<p class='count'>Khoảng " + jsonData.searchInformation.formattedTotalResults + " kết quả (" + jsonData.searchInformation.formattedSearchTime + ") giây</p>";
            foreach (var item in jsonData.items)
            {

                s += "<table id='daylabangne'><tr><td class='tddisplaylink'>" + item.displayLink + " " + @"<i class='fas fa-angle-down' style='font-size:13px;'></i>" + "</td></tr>";

                s += "<tr><td class='tdlink'>" + "<a href=" + item.link + @">" + item.title + @"</a>" + "</td></tr>";
                try
                {
                    s += "<tr style='display: flex;flex-direction: row;'><td><img width='100px'; src='" + item.pagemap.cse_thumbnail[0].src + "'></td><td class='tdsnippet'>" + item.snippet + "</td></tr> </table><br>";
                }
                catch (Exception ex)
                {

                }
            }
            lbResult.Text = s;
            btnNextPage.Visible = true;
            if (dem > 10)
            {
                btnPrePage.Visible = true;
            }
        }
    }
}
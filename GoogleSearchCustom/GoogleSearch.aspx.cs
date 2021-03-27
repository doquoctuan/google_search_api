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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=AIzaSyCbNot3KrQL719K-9DD5Zuzw-ogz_HJ1qM&cx=f8e752bbba9848d6c&q=" + txtKeyWord.Text);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            var results = new List<Models.Result>();
            string s = "Khoảng " + jsonData.searchInformation.formattedTotalResults + " kết quả (" + jsonData.searchInformation.formattedSearchTime + ") giây<br>";
            foreach (var item in jsonData.items)
            {

                s += item.displayLink + " " + @"<i class='fas fa-angle-down' style='font-size:13px;'></i>" + "<br>";
                s += "<a href=" + item.link + @">" + item.title + @"</a><br>";
                s += item.snippet + "<br><br>";     
            }
            lbResult.Text = s;
        }
    }
}
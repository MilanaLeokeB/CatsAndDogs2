using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CatsAndDogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAdog_Click(object sender, EventArgs e)
        {
            string dogImage = GetDogImageUrl();
            DogPicture.ImageLocation = dogImage;
            DogPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public static string GetDogImageUrl()
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            string imageUrl;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Dog dog = JsonConvert.DeserializeObject<Dog>(response);

                imageUrl = dog.message;
            }
            return imageUrl;
        }

        private void GetAcAT_Click(object sender, EventArgs e)
        {
            string catImage = GetCatImage();
            CatPicture.ImageLocation = catImage;
            CatPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string GetCatImageUrl()
        {
            throw new NotImplementedException();
        }

        public static string GetCatImage()
        {
            string url = "https://api.thecatapi.com/v1/images/search";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            string CatImage;

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                JavaScriptSerializer ser = new JavaScriptSerializer();

                List<Cat> catList = ser.Deserialize<List<Cat>>(response);
                CatImage = catList[0].url;

            }
            return CatImage;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SILS.API
{
    public class PictureAPI
    {

        #region singleton
        private PictureAPI()
        {
        }

        private static PictureAPI _instance = null;

        public static PictureAPI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PictureAPI();

                return _instance;
            }
        }
        #endregion


        public Bitmap WebImageView(string isbn)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            var json = web.DownloadString($"http://data4library.kr/api/srchDtlList?authKey=3cacb648eebbd3eb2f908f4b499e3b2914fed0669f4b263f7378fe45edb26a7d&isbn13={isbn}&format=json");

            dynamic content = JsonConvert.DeserializeObject<dynamic>(json);

            try
            {
                string bookPictureURL = content.response.detail[0].book.bookImageURL.ToString();

                WebClient webClient = new WebClient();
                Stream stream = webClient.OpenRead(bookPictureURL);
                Bitmap bitmap = Bitmap.FromStream(stream) as Bitmap;
                return bitmap;

            }
            catch
            {
                return null;
            }
        }
    }
}

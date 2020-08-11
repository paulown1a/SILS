using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SILS.API
{
    
    public class LibraryAPI
    {

        #region singleton
        private LibraryAPI()
        {
        }

        private static LibraryAPI _instance = null;

        public static LibraryAPI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LibraryAPI();

                return _instance;
            }
        }
        #endregion

        public string LibraryId { get; set; }
        public string Name { get; set; }
        public string[] LocationId { get; set; } = new string[2];
        public string Address { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public static LibraryAPI Convert(dynamic value)
        {
            LibraryAPI library = new LibraryAPI();
            if (value.libCode == null)
                return null;
            library.LibraryId = value.libCode.ToString();
            library.Name = value.libName.ToString();
            library.Address = value.address.ToString();
            library.Website = value.homepage == null ? null : value.homepage.ToString();
            library.PhoneNumber = value.tel == null ? null : value.tel.ToString();
            string address = value.address.ToString();
            string[] token = address.Split(' ');
            library.LocationId[0] = token[0].Substring(0, 2);
            library.LocationId[1] = token[1];
            return library;
        }

        //..
        public List<LibraryAPI> LoadLibraries(int pageNumber)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            var json = web.DownloadString($"http://data4library.kr/api/libSrch?authKey=3cacb648eebbd3eb2f908f4b499e3b2914fed0669f4b263f7378fe45edb26a7d&pageNo={pageNumber}&pageSize=500&format=json");

            dynamic content = JsonConvert.DeserializeObject<dynamic>(json);

            List<LibraryAPI> libraries = new List<LibraryAPI>(int.Parse(content.response.request.pageSize.ToString()));

            foreach (dynamic item in content.response.libs)
            {
                dynamic lib = item.lib;
                LibraryAPI library = LibraryAPI.Convert(lib);
                if (library != null)
                    libraries.Add(library);
            }

            return libraries;
        }
    }

}

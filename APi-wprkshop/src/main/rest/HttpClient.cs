using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.rest
{
    internal class HttpClient
    {
        

        public RestResponse get(string url,RestRequest request) {
            RestClient client = new RestClient(url);

            return client.Get(request); 
        }

        public RestResponse post(string url, RestRequest request) {
            RestClient client = new RestClient(url);

            return client.Post(request); 
        }

        public RestResponse put(string url, RestRequest request) {
            RestClient client = new RestClient(url);

            return client.Put(request); 
        }

        public RestResponse patch(string url, RestRequest request)
        {
            RestClient client = new RestClient(url);

            return client.Patch(request);
        }

        public RestResponse delete(string url, RestRequest request)
        {
            RestClient client = new RestClient(url);

            return client.Delete(request);
        }
    }
}

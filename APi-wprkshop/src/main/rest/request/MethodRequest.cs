using APIworkshop.src.main.rest.dto;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.rest.request
{
    internal class MethodRequest
    {
        public HttpClient httpClient = new HttpClient();
        private RestRequest request = new RestRequest();
        private string apiUrl = "https://www.httpbin.org/anything";

        public RestResponse getMethod(BodyExample dto)
        {
            this.request.AddHeader("Content-Type", "application/json");
            this.request.AddBody(dto);

            return this.httpClient.get(this.apiUrl, this.request);
        }

        public RestResponse postMethod(BodyExample dto)
        {
            this.request.AddHeader("Content-Type", "application/json");
            this.request.AddBody(dto);

            return this.httpClient.post(this.apiUrl, this.request);
        }

        public RestResponse putMethod(BodyExample dto)
        {
            this.request.AddHeader("Content-Type", "application/json");
            this.request.AddBody(dto);

            return this.httpClient.put(this.apiUrl, this.request);
        }

        public RestResponse patchMethod(BodyExample dto)
        {
            this.request.AddHeader("Content-Type", "application/json");
            this.request.AddBody(dto);

            return this.httpClient.patch(this.apiUrl, this.request);
        }

        public RestResponse deleteMethod(BodyExample dto)
        {
            this.request.AddHeader("Content-Type", "application/json");
            this.request.AddBody(dto);

            return this.httpClient.delete(this.apiUrl, this.request);
        }
    }
}

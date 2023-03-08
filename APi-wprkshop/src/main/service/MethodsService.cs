using APIworkshop.src.main.rest.dto;
using APIworkshop.src.main.rest.request;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.service
{
    internal class MethodsService
    {
        private MethodRequest request = new MethodRequest();

        public RestResponse useMethod(string method, BodyExample dto)
        {
            RestResponse response = null;

            switch(method)
            {
                case "GET":
                    response = this.request.getMethod(dto);
                    break;

                case "POST":
                    response = this.request.postMethod(dto);
                    break;

                case "PUT":
                    response = this.request.putMethod(dto);
                    break;

                case "PATCH":
                    response = this.request.patchMethod(dto);
                    break;

                case "DELETE":
                    response = this.request.deleteMethod(dto);
                    break;

                default:
                    Assert.NotNull(response);
                    break;
            }

            return response;
        }
    }
}

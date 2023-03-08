using APIworkshop.src.main.rest.dto;
using APIworkshop.src.main.service;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.controller
{
    internal class MethodsController
    {
        private MethodsService service = new MethodsService();

        public RestResponse useMethod(string method, BodyExample dto) { return this.service.useMethod(method, dto); }
    }
}

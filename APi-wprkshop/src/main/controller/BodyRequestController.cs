using APIworkshop.src.main.rest.dto;
using APIworkshop.src.main.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.controller
{
    internal class BodyRequestController
    {
        private BodyRequestService service = new BodyRequestService();

        public BodyExample newBodyRequest(string name, string lastName, int age) { return this.service.createBodyRequest(name, lastName, age); }
    }
}

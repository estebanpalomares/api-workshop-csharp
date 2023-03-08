using APIworkshop.src.main.rest.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.main.service
{
    internal class BodyRequestService
    {
        private BodyExample dto = new BodyExample();

        public BodyExample createBodyRequest(string name, string lastName, int age)
        {
            this.dto.Name = name;
            this.dto.LastName = lastName;
            this.dto.Age = age;

            return this.dto;
        }
    }
}

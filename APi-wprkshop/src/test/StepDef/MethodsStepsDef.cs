using APIworkshop.src.main.controller;
using APIworkshop.src.main.rest.dto;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIworkshop.src.test.StepDef
{
    [Binding]
    internal class MethodsStepsDef
    {
        private BodyExample dto = new BodyExample();
        private BodyRequestController dtoController = new BodyRequestController();
        private MethodsController methodsController = new MethodsController();
        private RestResponse response = new RestResponse();

        [Given(@"A user have a Body Request")]
        public void GivenAUserHaveABodyRequest()
        {
            this.dto = this.dtoController.newBodyRequest("Jhon", "Doe", 40);
        }

        [When(@"A user ""([^""]*)"" the endpoint")]
        public void WhenAUserTheEndpoint(string method)
        {
            this.response = this.methodsController.useMethod(method,this.dto);
        }

        [Then(@"A user verify the response")]
        public void ThenAUserVerifyTheResponse()
        {
            Assert.Equal(200, ((int)this.response.StatusCode));
        }

    }
}

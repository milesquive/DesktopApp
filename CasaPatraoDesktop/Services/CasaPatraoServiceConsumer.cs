using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using CasaPatraoDesktop.Domain;
using RestSharp;
using Newtonsoft.Json;

namespace CasaPatraoDesktop.Services
{
    class CasaPatraoServiceConsumer
    {
        private const string URL = "http://localhost/api/product/read.php";
        private static string urlParameters = "";

        public ProductDomain getProducts()
        {
            var client = new RestClient("http://localhost/api/product/read.php");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "Phpstorm-371f3b14=a07a8494-f6c6-407a-a970-e83853c40887");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost");
            request.AddHeader("Postman-Token", "5ef41af7-6701-4ce6-95fe-922398c70eb7,05fb6f9c-7959-499e-bc57-18f10ff17568");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.17.1");
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                ProductDomain product = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDomain>(response.Content);
                return product;
            }

            return new ProductDomain();
        }

        public void createProduct()
        {
            var client = new RestClient("http://localhost/api/product/create.php");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "Phpstorm-371f3b14=a07a8494-f6c6-407a-a970-e83853c40887");
            request.AddHeader("Content-Length", "217");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "localhost");
            request.AddHeader("Postman-Token", "40b45a8c-0c39-4c59-b1ec-6a22532ecae8,95e55ca6-2492-439e-8609-28d5bbe92005");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.17.1");
            request.AddHeader("Content-Type", "text/plain");
            request.AddParameter("undefined", "{\r\n    \"productBarcode\" : \"0000\",\r\n    \"productDesc\" : \"199\",\r\n    \"prodQuant\" : \"0\",\r\n    \"productPurchaseprice\" : 2,\r\n    \"productSaleprice\" : \"76\",\r\n    \"productLastquant\" : \"84\",\r\n    \"productPreateuser\"\": \"98\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

            }

        }
    }
}



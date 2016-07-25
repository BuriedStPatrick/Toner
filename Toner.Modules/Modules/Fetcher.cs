using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Toner.Core.Models;

namespace Toner.Modules.Modules
{
    public class Fetcher
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Fetcher(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string GetJsonData(Parameter parameter)
        {
            var postData = JsonConvert.SerializeObject(parameter);
            var request = (HttpWebRequest) WebRequest.Create(ConfigurationManager.AppSettings["Toner.EndpointUrl"]);
            var auth = $"{Username}:{Password}";
            var auth64 = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
            var credentials = $"Basic {auth64}";

            request.Headers[HttpRequestHeader.Authorization] = credentials;
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/json";

            var byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;

            var dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            var response = request.GetResponse();
            Console.WriteLine($"Response: {((HttpWebResponse)response).StatusDescription}");
            dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            var responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }
    }
}

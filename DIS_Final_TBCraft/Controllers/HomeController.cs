using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIS_Final_TBCraft.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace DIS_Final_TBCraft.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        static string BASE_URL = "https://api.openbrewerydb.org";
        static string API_KEY = "";

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Breweries()
        {
            return View();
        }
        public IActionResult Beers()
        {
            return View();
        }
        public IActionResult Charts()
        {
            return View();
        }
        public IActionResult ViewBrewApi()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string BEER_API_PATH = BASE_URL + "/breweries?by_city=tampa";
            string breweryapidata = "";

            List<Class1> Breweryapi = null;

            httpClient.BaseAddress = new Uri(BEER_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(BEER_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    breweryapidata = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    breweryapidata = breweryapidata.Replace("[", "").Replace("]", "");
                }

                if (!breweryapidata.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    //Breweryapi = JsonConvert.DeserializeObject<Models.Rootobject>(breweryapidata);
                    Breweryapi = JsonConvert.DeserializeObject<List<Models.Class1>>(breweryapidata);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(Breweryapi);
        }
    }
}
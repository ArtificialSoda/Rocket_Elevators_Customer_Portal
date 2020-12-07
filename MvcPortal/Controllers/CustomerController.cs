using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http;
using MvcPortal.Models;

namespace MvcPortal.Controllers 
{
    public class CustomerController : Controller 
    {
        public static string ApiURL(string parameter,long? id = null)
        {  
            string url;
            string baseUrl = "https://rocket-elevators-api-rest.azurewebsites.net/api/";
            if(id == null)
            {            
                url =  baseUrl + parameter ;
            }
            else
            {
                url = baseUrl + parameter + $"{id}";
            }
            return url;
        }

        // GET all customers
        public static async Task<List<Customer>> GetCustomersList()
        {  
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL("customer/all"));
            var content = res.Content.ReadAsStringAsync().Result;
            var customersList = JsonSerializer.Deserialize<List<Customer>>(content);
            return customersList;
        }

        public static async Task<Customer> GetCustomer(string customer_email)
        {
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL($"customer/{customer_email}"));
            var content = res.Content.ReadAsStringAsync().Result;

            var customer = JsonSerializer.Deserialize<Customer>(content);
            return customer;
        }

        public static async Task<List<string>> GetCustomerBuildingsList(ulong customer_id)
        {  
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL($"customer/{customer_id}/buildings"));
            var content = res.Content.ReadAsStringAsync().Result;
            
            var customerBuildingsList = JsonSerializer.Deserialize<List<string>>(content);
            return customerBuildingsList;
        }

        public static async Task<List<string>> GetCustomerBatteriesList(ulong customer_id)
        {  
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL($"customer/{customer_id}/batteries"));
            var content = res.Content.ReadAsStringAsync().Result;
            
            var customerBatteriesList = JsonSerializer.Deserialize<List<string>>(content);
            return customerBatteriesList;
        }

        public static async Task<List<string>> GetCustomerColumnsList(ulong customer_id)
        {  
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL($"customer/{customer_id}/columns"));
            var content = res.Content.ReadAsStringAsync().Result;
            
            var customerColumnsList = JsonSerializer.Deserialize<List<string>>(content);
            return customerColumnsList;
        }

        public static async Task<List<string>> GetCustomerElevatorsList(ulong customer_id)
        {  
            var client = new HttpClient();
            var res = await client.GetAsync(ApiURL($"customer/{customer_id}/elevators"));
            var content = res.Content.ReadAsStringAsync().Result;
            
            var customerBatteriesList = JsonSerializer.Deserialize<List<string>>(content);
            return customerBatteriesList;
        }



        


    }
}
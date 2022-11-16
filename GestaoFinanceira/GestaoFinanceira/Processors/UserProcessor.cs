using GestaoFinanceira.Consumer;
using GestaoFinanceira.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira
{
    public class UserProcessor
    {
        public static async Task<string> Login(string username, string password)
        {
            string url = "https://localhost:7020/User/Login";

            User user = new User{
                Login = username, 
                Password = password,
            };
            using (HttpResponseMessage response = await APIConsumer.ApiClient.PostAsync(url, new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json")))
            {
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
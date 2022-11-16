using GestaoFinanceira.Consumer;
using GestaoFinanceira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GestaoFinanceira
{
    public class TransactionProcessor
    {
        public static async Task<List<Transaction>> GetTransactions(int id)
        {
            string url = $"https://localhost:7020/Transaction/{id}";

            using (HttpResponseMessage response = await APIConsumer.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Transaction> transactions = await response.Content.ReadAsAsync<List<Transaction>>();

                    return transactions;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

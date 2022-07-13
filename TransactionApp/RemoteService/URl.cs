using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionApp.RemoteService
{
    public class URl
    {
       public  static URl instance = new URl();
       private  string transactionUrl = "https://61769aed03178d00173dad89.mockapi.io/api/v1/transactions";

        private string transactionDetailsUr = $"https://61769aed03178d00173dad89.mockapi.io/api/v1/transactions/";
        public string GetTransactionUrl() 
        
        {
            return transactionUrl;
        }
        public string GetTransactionDetailsUrl(string id)

        {
            return transactionDetailsUr+id;
        }
    }
}
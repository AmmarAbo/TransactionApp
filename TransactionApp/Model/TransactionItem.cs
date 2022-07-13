using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace TransactionApp.Model
{
    public class TransactionItem
    {
        [JsonProperty(PropertyName = "createdAt")]
        public  string createdAt { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "bank_name")]
        public string bankName { get; set; }
        [JsonProperty(PropertyName = "transfer_type")]
        public string transfertType { get; set; }
        [JsonProperty(PropertyName = "receiving_amount")]
        public string receivingAmount { get; set; }
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }
        [JsonProperty(PropertyName = "reference_number")]
        public string referenceNumber { get; set; }
        [JsonProperty(PropertyName = "payout_location")]
        public string payoutLocation { get; set; }
        [JsonProperty(PropertyName = "account_number")]
        public string accountNumber { get; set; }
        [JsonProperty(PropertyName = "paid_amount")]
        public string paidAmount { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        


    }
    
}
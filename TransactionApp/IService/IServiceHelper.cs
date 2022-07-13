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
using System.Threading.Tasks;
using TransactionApp.Model;

namespace TransactionApp.IService
{
    public interface IServiceHelper
    {
        Task<List<TransactionItem>> GetTransactions();
        Task<TransactionItem> GetTransactionDetails(string TransactionId);
    }
}
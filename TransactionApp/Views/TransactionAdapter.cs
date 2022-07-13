using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionApp.Model;

namespace TransactionApp.Views
{
    public class TransactionAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        List<TransactionItem> transactionItems = new List<TransactionItem>();
      public TransactionAdapter(List<TransactionItem> transactionItems)
        {
            this.transactionItems = transactionItems;
        }

        public override int ItemCount => transactionItems.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TRansactionViewHolder vh = holder as TRansactionViewHolder;
            
            vh.transactionName.Text = transactionItems[position].name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.transaction_item, parent, false);
            TRansactionViewHolder vh = new TRansactionViewHolder(itemView, OnClick);
            return vh;
        }
        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
    public class TRansactionViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Image { get; set; }
        public TextView transactionName { get; set; }
        public TextView bankName { get; set; }
        public TextView tansfrerType { get; set; }
        public TRansactionViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            Image = itemview.FindViewById<ImageView>(Resource.Id.flagImage);
            transactionName = itemview.FindViewById<TextView>(Resource.Id.transactoinName);
            itemview.Click += (sender, e) => listener(base.Position);
        }
    }
}
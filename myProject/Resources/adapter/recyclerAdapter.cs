﻿

using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using myProject.Resources.dataHelper;
using System;
using System.Collections.Generic;

namespace myProject.Resources.adapter
{
    class recyclerAdapter : RecyclerView.Adapter
    {
        public event EventHandler<recyclerAdapterClickEventArgs> ItemClick;
        public event EventHandler<recyclerAdapterClickEventArgs> ItemLongClick;
        List<dataModel> list;
        Context context;
        public recyclerAdapter(List<dataModel> data,Context context)
        {
            list = data;
            this.context = context;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.abc;
            itemView = LayoutInflater.From(parent.Context).
                   Inflate(id, parent, false);

            var vh = new recyclerAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = list[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as recyclerAdapterViewHolder;
            //holder.TextView.Text = items[position];
            holder.textOne.Text = item.Name;
            holder.textTwo.Text = item.Description;
            holder.image.SetImageResource(item.Image);
            holder.card.SetBackgroundResource(item.color);
            
        }

        public override int ItemCount => list.Count;

        void OnClick(recyclerAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(recyclerAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class recyclerAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }

        public TextView textOne, textTwo;
        public ImageView image;
        public CardView card;
        public recyclerAdapterViewHolder(View itemView, Action<recyclerAdapterClickEventArgs> clickListener,
                            Action<recyclerAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
            itemView.Click += (sender, e) => clickListener(new recyclerAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new recyclerAdapterClickEventArgs { View = itemView, Position = AdapterPosition });

            textOne = itemView.FindViewById<TextView>(Resource.Id.textViewName);
            textTwo = itemView.FindViewById<TextView>(Resource.Id.textViewTwo);
            image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            card = itemView.FindViewById<CardView>(Resource.Id.cardView1);
        }
    }

    public class recyclerAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}
using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Globalization;

namespace Parqueo_Movil___Xamarin
{
    class Adaptador : RecyclerView.Adapter
    {
        public event EventHandler<AdaptadorClickEventArgs> ItemClick;
        public event EventHandler<AdaptadorClickEventArgs> ItemLongClick;
        IPuesto [] items;

        public Adaptador(IPuesto[] data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.Vista;
            itemView = LayoutInflater.From(parent.Context).
                  Inflate(id, parent, false);

            var vh = new AdaptadorViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as AdaptadorViewHolder;
            //holder.TextView.Text = items[position];
        }

        public override int ItemCount => items.Length;

        void OnClick(AdaptadorClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(AdaptadorClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class AdaptadorViewHolder : RecyclerView.ViewHolder
    {
        public TextView txtpuestovista { get; set; }
        public TextView txtlibrevista { get; set; }
        public TextView txtplacavista { get; set; }
        public TextView txthoravista { get; set; }


        public AdaptadorViewHolder(View itemView, Action<AdaptadorClickEventArgs> clickListener,
                            Action<AdaptadorClickEventArgs> longClickListener) : base(itemView)
        {
            //txtpuestovista = (TextView)itemView.findViewById(R.id.txtPuestoVista);
            //txtlibrevista = (TextView)itemView.findViewById(R.id.txtLibreVista);
            //txtplacavista = (TextView)itemView.findViewById(R.id.txtPlacaVista);
            //txthoravista = (TextView)itemView.findViewById(R.id.txtHoraVista);
            //TextView = v;
            //itemView.Click += (sender, e) => clickListener(new AdaptadorClickEventArgs { View = itemView, Position = AdapterPosition });
            //itemView.LongClick += (sender, e) => longClickListener(new AdaptadorClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class AdaptadorClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}
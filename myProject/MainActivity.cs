using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using myProject.Resources.adapter;
using myProject.Resources.dataHelper;
using System;
using System.Collections.Generic;

namespace myProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView myRecyclerView;
        recyclerAdapter myAdapter;
        List<dataModel> myDataModel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            myRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            addingData();

            myAdapter = new recyclerAdapter(myDataModel , this);
            //myRecyclerView.SetLayoutManager(new GridLayoutManager(this,2,GridLayoutManager.Horizontal,false));
            myRecyclerView.SetLayoutManager(new LinearLayoutManager(this));
            myRecyclerView.SetAdapter(myAdapter);


        }

        private void addingData()
        {
           myDataModel = new List<dataModel> 
           {
               new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food ,color=Resource.Drawable.bluecolor },
                new dataModel{Name = "Arish", Description="Engineer" ,Image = Resource.Drawable.ic_dress,color=Resource.Color.material_blue_grey_950},
                 new dataModel{Name = "Vruti", Description="Engineer" ,Image = Resource.Drawable.ic_favourite ,color = Resource.Color.colorPrimaryDark},
                  new dataModel{Name = "Mayank", Description="Engineer",Image = Resource.Drawable.ic_home  },
                   new dataModel{Name = "Vedancy", Description="Engineer" ,Image = Resource.Drawable.ic_money },
                    new dataModel{Name = "Devance", Description="Engineer" ,Image = Resource.Drawable.ic_motorcycle },
                     new dataModel{Name = "Mit", Description="Engineer",Image = Resource.Drawable.ic_favourite  },
                      new dataModel{Name = "Hinal", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                       new dataModel{Name = "Sagar", Description="Engineer",Image = Resource.Drawable.ic_food  },
                       new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                       new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                       new dataModel{Name = "Arish", Description="Engineer" ,Image = Resource.Drawable.ic_dress },
                      new dataModel{Name = "Vruti", Description="Engineer" ,Image = Resource.Drawable.ic_favourite },
                     new dataModel{Name = "Mayank", Description="Engineer",Image = Resource.Drawable.ic_home  },
                   new dataModel{Name = "Vedancy", Description="Engineer" ,Image = Resource.Drawable.ic_money },
                 new dataModel{Name = "Devance", Description="Engineer" ,Image = Resource.Drawable.ic_motorcycle },
                new dataModel{Name = "Mit", Description="Engineer",Image = Resource.Drawable.ic_favourite  },
               new dataModel{Name = "Hinal", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                new dataModel{Name = "Sagar", Description="Engineer",Image = Resource.Drawable.ic_food  },
                 new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                  new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                   new dataModel{Name = "Arish", Description="Engineer" ,Image = Resource.Drawable.ic_dress },
                    new dataModel{Name = "Vruti", Description="Engineer" ,Image = Resource.Drawable.ic_favourite },
                     new dataModel{Name = "Mayank", Description="Engineer",Image = Resource.Drawable.ic_home  },
                      new dataModel{Name = "Vedancy", Description="Engineer" ,Image = Resource.Drawable.ic_money },
                      new dataModel{Name = "Devance", Description="Engineer" ,Image = Resource.Drawable.ic_motorcycle },
                      new dataModel{Name = "Mit", Description="Engineer",Image = Resource.Drawable.ic_favourite  },
                      new dataModel{Name = "Hinal", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                     new dataModel{Name = "Sagar", Description="Engineer",Image = Resource.Drawable.ic_food  },
                   new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                  new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                 new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
                new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food },
               new dataModel{Name = "Priyank", Description="Engineer" ,Image = Resource.Drawable.ic_food }


           };
        }
    }
}
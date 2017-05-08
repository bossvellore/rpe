using Android.App;
using Android.Widget;
using Android.OS;
using com.refractored.fab;
using Android.Content;

namespace Event_Management
{
    [Activity(Label = "Events", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        ListView elv;
        Button nav;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);


            elv = FindViewById<ListView>(Resource.Id.eventListView);
            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.AttachToListView(elv);

            fab.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(EventAdd));
                    StartActivity(intent);
            };
        }
    }
}


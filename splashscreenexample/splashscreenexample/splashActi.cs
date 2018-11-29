using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace splashscreenexample
{
    [Activity(Theme = "@styles/Splashtheme", MainLauncher = true, NoHistory = true)]
    public class splashActi : AppCompatActivity
    {

        static readonly string TAG = "X: " + typeof(splashActi).Name;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SupportActionBar.Hide();
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startup = new Task(() => { SimulateStartup(); });

  
        }

        async void SimulateStartup()
        {
            await Task.Delay(8000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
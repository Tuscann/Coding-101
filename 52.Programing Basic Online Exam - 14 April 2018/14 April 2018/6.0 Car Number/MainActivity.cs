using Android.App;
using Android.Widget;
using Android.OS;

namespace _6._0_Car_Number
{
    [Activity(Label = "_6._0_Car_Number", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}


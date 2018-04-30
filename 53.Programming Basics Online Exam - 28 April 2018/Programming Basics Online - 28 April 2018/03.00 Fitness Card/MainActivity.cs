using Android.App;
using Android.Widget;
using Android.OS;

namespace _03._00_Fitness_Card
{
    [Activity(Label = "_03._00_Fitness_Card", MainLauncher = true)]
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


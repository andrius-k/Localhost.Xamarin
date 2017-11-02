using Android.App;
using Android.Widget;
using Android.OS;

namespace LocalhostSample.Droid
{
    [Activity(Label = "LocalhostSample.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.ipTextView);

            textView.Text = Sample.GetIP();
        }
    }
}


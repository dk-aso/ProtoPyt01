using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace ProtoPyt01
{
    [Activity(Label = "ProtoPyt01", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ImageButton button = FindViewById<ImageButton>(Resource.Id.Pyt1Button);
            TextView txtView = FindViewById<TextView>(Resource.Id.TextView1);
            string txt1 = "Så PYT da, og nu er det videre i livet";
            string txt2 = "Så er der PYTTET, og der er fri bane frem";

            button.Click += delegate
            {
                int val = DateTime.Now.Second;
                if (val % 2 == 0)
                {
                    txtView.Text = txt1;
                    txtView.SetBackgroundColor(Color.ParseColor("Blue"));
                }
                else
                {
                    txtView.Text = txt2;
                    txtView.SetBackgroundColor(Color.ParseColor("Green"));
                }
            };
        }
    }
}


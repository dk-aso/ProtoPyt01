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
            String txt3 = "Du har valgt at sige pyt, så kom videre i livet!";
            String txt4 = "Da har valg at trykke PYT, det betyder at du ikke skal bruge mere energi på det du har pyttet!";
            String txt5 = "PYT!! Og så er der fri bane fremad!";
            String txt6 = "PYT!! Ting sker, og det der er sket lige nu er kun et PYT værd, og skal ikke have inflydelse på dit humør.";
            String txt7 = "Det var så det! Med et PYT er det overstået og får ikke mere indflydelse på dig og dit liv.";

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


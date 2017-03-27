using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content.Res;

namespace ProtoPyt01
{
    [Activity(Label = "ProtoPyt", MainLauncher = true, Icon = "@drawable/GiftIcon72")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource fonts/grov_condensed_alphabet_regular.otf
            SetContentView(Resource.Layout.Main);
         //   Button button01 = FindViewById<Button>(Resource.Id.Pyt2Button);
            TextView txtView = FindViewById<TextView>(Resource.Id.TextView1);
            Typeface tf = Typeface.CreateFromAsset(Assets, "fonts/FalturaRegular.ttf");
            txtView.Typeface = tf;
            string txt1 = "Så PYT da, og nu er det videre med livet!";
            string txt2 = "Så er der PYTTET, og der er igen fri bane frem!";
            string txt3 = "Du har valgt at sige PYT, så kom videre i livet!";
            string txt4 = "Du har valg at trykke PYT, det betyder, at du ikke skal bruge mere energi, på det du netop har pyttet!";
            string txt5 = "PYT!! Og så er der fri bane fremad!";
            string txt6 = "PYT!! Ting sker, og det der er sket lige nu er kun et PYT værd, og skal ikke have inflydelse på dit humør!";
            string txt7 = "Det var så det! Med et PYT er det overstået og får ikke mere indflydelse på dig og dit liv!";

            /*button01.Click += delegate
            {
                int val = DateTime.Now.Second % 7;
                switch (val)
                {
                    case 1:
                        txtView.Text = txt2;
                        break;
                    case 2:
                        txtView.Text = txt3;
                        break;
                    case 3:
                        txtView.Text = txt4;
                        break;
                    case 4:
                        txtView.Text = txt5;
                        break;
                    case 5:
                        txtView.Text = txt6;
                        break;
                    case 6:
                        txtView.Text = txt7;
                        break;
                    default:
                        txtView.Text = txt1;
                        break;
                }
            };*/
            Button button02 = FindViewById<Button>(Resource.Id.Pyt3Button);
            button02.Click += delegate
            {
                int val = DateTime.Now.Second % 7;
                switch (val)
                {
                    case 1:
                        txtView.Text = txt2;
                        break;
                    case 2:
                        txtView.Text = txt3;
                        break;
                    case 3:
                        txtView.Text = txt4;
                        break;
                    case 4:
                        txtView.Text = txt5;
                        break;
                    case 5:
                        txtView.Text = txt6;
                        break;
                    case 6:
                        txtView.Text = txt7;
                        break;
                    default:
                        txtView.Text = txt1;
                        break;
                }
            };
        }
    }
}


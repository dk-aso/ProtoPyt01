﻿using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace ProtoPyt01
{
    [Activity(Label = "ProtoPyt01", MainLauncher = true, Icon = "@drawable/GiftIcon72")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //ImageButton button = FindViewById<ImageButton>(Resource.Id.Pyt1Button);
            Button button01 = FindViewById<Button>(Resource.Id.Pyt2Button);
            TextView txtView = FindViewById<TextView>(Resource.Id.TextView1);
            string txt1 = "Så PYT da, og nu er det videre med livet";
            string txt2 = "Så er der PYTTET, og der er fri bane frem";
            string txt3 = "Du har valgt at sige PYT, så kom videre i livet!";
            string txt4 = "Du har valg at trykke PYT, det betyder at du ikke skal bruge mere energi på det du netop har pyttet!";
            string txt5 = "PYT!! Og så er der fri bane fremad!";
            string txt6 = "PYT!! Ting sker, og det der er sket lige nu er kun et PYT værd, og skal ikke have inflydelse på dit humør.";
            string txt7 = "Det var så det! Med et PYT er det overstået og får ikke mere indflydelse på dig og dit liv.";

            button01.Click += delegate
            {
                int val = DateTime.Now.Second % 7;
                switch (val)
                {
                    case 1:
                        txtView.Text = txt2;
                        //txtView.SetBackgroundColor(Color.ParseColor("#000000"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground2);
                        break;
                    case 2:
                        txtView.Text = txt3;
                        //txtView.SetBackgroundColor(Color.ParseColor("#545454"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground3);
                        break;
                    case 3:
                        txtView.Text = txt4;
                        //txtView.SetBackgroundColor(Color.ParseColor("#896262"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground4);
                        break;
                    case 4:
                        txtView.Text = txt5;
                        //txtView.SetBackgroundColor(Color.ParseColor("#ba9580"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground5);
                        break;
                    case 5:
                        txtView.Text = txt6;
                        //txtView.SetBackgroundColor(Color.ParseColor("#c7c793"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground6);
                        break;
                    case 6:
                        txtView.Text = txt7;
                        //txtView.SetBackgroundColor(Color.ParseColor("#c5718b"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground7);
                        break;
                    default:
                        txtView.Text = txt1;
                        //txtView.SetBackgroundColor(Color.ParseColor("#7dc3b7"));
                        txtView.SetBackgroundResource(Resource.Drawable.MyTextBackground1);
                        break;
                }
            };
        }
    }
}


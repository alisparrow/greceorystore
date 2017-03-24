using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
    [Activity(Theme = "@android:style/Theme.Material.Light.DarkActionBar", Label = "TipCalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       EditText inputBill;
        TextView outputTip;
        TextView outputTotal;
        Button calculateButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);
            calculateButton.Click += CalculateButton_Click;
        }

         void CalculateButton_Click(object sender, EventArgs e)
        {
           var text = inputBill.Text;
            komisiyonmelk.komesiyon c = new komisiyonmelk.komesiyon();
            c.TotallKomesiyone = UInt64.Parse(text);
            if (c.TotallKomesiyone <= komisiyonmelk.komesiyon.Sadmilion)
                c.PlanOne();
            else if (c.TotallKomesiyone <= komisiyonmelk.komesiyon.Divestmilion)
            {
                c.PlanTow();
                c.PlanOne();
            }
            else if (c.TotallKomesiyone <= komisiyonmelk.komesiyon.Divestmilion)
            {

                c.PlanThree();
                c.PlanOne();
                c.PlanTow();
            }
            else
            {
                c.PlanFour();
                c.PlanOne();
                c.PlanTow();
                c.PlanThree();
            }
            outputTip.Text = c.Streamoutput.ToString();


        }
    }
}


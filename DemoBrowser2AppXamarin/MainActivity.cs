using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Com.Browser2app.Khenshin;

namespace DemoBrowser2AppXamarin
{
    [Activity(Label = "DemoBrowser2AppXamarinApplication", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate {



                var paymentIntent = DemoBrowser2AppXamarinApplication.Current.Khenshin.StartTaskIntent;
                paymentIntent.PutExtra(KhenshinConstants.ExtraAutomatonId, "Bawdf");

                var bundle = new Bundle();
				bundle.PutString("subject", "Pago prueba");
				bundle.PutString("amount", "2000");
				bundle.PutString("merchant", "Comercio de prueba");
				bundle.PutString("paymentId", "aosjdoaijsdoiaj");
				bundle.PutString("khipu_account_name", "PAGOCMR");
				bundle.PutString("khipu_account_number", "55200104571");
				bundle.PutString("khipu_alias", "PAGOCMR");
				bundle.PutString("payer_name", "Emilio Davis");
				bundle.PutString("payer_email", "cmr@khipu.com");
				bundle.PutString("khipu_rut", "10.706.077-4");
				bundle.PutString("khipu_email", "transferencias@khipu.com");

                paymentIntent.PutExtra(KhenshinConstants.ExtraAutomatonParameters, bundle);

                StartActivityForResult(paymentIntent, 101);

            
            };
        }
    }
}


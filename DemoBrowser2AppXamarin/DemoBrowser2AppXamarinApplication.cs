
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Browser2app.Khenshin;

namespace DemoBrowser2AppXamarin
{
    [Application]
    public class DemoBrowser2AppXamarinApplication : Application, IKhenshinApplication
    {

        public static DemoBrowser2AppXamarinApplication Current { get; set; }

        public IKhenshinInterface Khenshin { get; set; }

        public DemoBrowser2AppXamarinApplication(IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
        : base(handle, transfer)
        {

		}
		public override void OnCreate()
		{
			base.OnCreate();
			Current = this;
            Khenshin  = new Khenshin.KhenshinBuilder()
						.SetApplication(this)
						.SetTaskAPIUrl("https://cmr.browser2app.com/api/automata/")
						.SetDumpAPIUrl("https://cmr.browser2app.com/api/automata/")
						//.SetTaskAPIUrl("https://khipu.com/app/2.0/")
						//.SetDumpAPIUrl("https://khipu.com/cerebro/")
						.SetMainButtonStyle(1)
						.SetAutomatonTimeout(90)
						.SetAllowCredentialsSaving(true)
						.SetHideWebAddressInformationInForm(false)
                        .SetSkipExitPage(false)
						.Build();
		}



    }
}

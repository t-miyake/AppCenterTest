using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AppCenterSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new AppCenterSample.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts

		    AppCenter.Start("android=90bb2f45-909e-45a2-a153-614bbcad7be8;" + "uwp=5874fe67-b8a0-4054-a72f-4f2d87de828f;" +
                            "ios=5117a5f1-74ef-4cbf-96de-67973296abe9",
		        typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

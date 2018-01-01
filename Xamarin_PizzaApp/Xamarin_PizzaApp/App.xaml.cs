﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin_PizzaApp.View;

namespace Xamarin_PizzaApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new PizzaLoginPage());
            //MainPage = new NavigationPage(new NewCustomerSignUpPage());
            //MainPage = new NavigationPage(new PizzaOrderPage());
            //MainPage = new NavigationPage(new OrderPaymentPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
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

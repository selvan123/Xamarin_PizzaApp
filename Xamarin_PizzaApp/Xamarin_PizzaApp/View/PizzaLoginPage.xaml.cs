using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_PizzaApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PizzaLoginPage : ContentPage
	{
		public PizzaLoginPage ()
		{
			InitializeComponent ();
		}

        //This will need to be moved.
        async void OnNewCustomerSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCustomerSignUpPage());
        }
    }
}
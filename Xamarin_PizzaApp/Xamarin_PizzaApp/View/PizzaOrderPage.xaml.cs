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
	public partial class PizzaOrderPage : ContentPage
	{
		public PizzaOrderPage ()
		{
			InitializeComponent ();
		}

        void OnPizzaQuantityChanged(object sender, ValueChangedEventArgs e)
        {
            pizzaQuantityCount.Text = String.Format("Pizza(s): {0}", e.NewValue);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_PizzaApp
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public String Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            else
            {
                var imageSource = ImageSource.FromResource(Source);

                return imageSource;
            }
        }
    }
}

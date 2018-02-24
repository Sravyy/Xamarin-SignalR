using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class imagePage : ContentPage
	{
		public imagePage ()
		{
			InitializeComponent ();

            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            //imageSource.CachingEnabled = false;
            ////imageSource.CacheValidity = TimeSpan.FromHours(1);

            //image.Source = imageSource;
            //image.Source = "http://...";

        }
	}
}
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
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
			InitializeComponent ();

            //var layout = new StackLayout
            //{
            //    Spacing = 40,
            //    Padding = new Thickness(20, 20, 20, 20),
            //    Orientation = StackOrientation.Vertical
            //};
            //layout.Children.Add(new Label { Text = "Lab 1" });
            //layout.Children.Add(new Label { Text = "Lab 1" });
            //layout.Children.Add(new Label { Text = "Lab 1" });

            //Content = layout;
		}
	}
}
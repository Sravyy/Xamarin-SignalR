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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            //var grid = new Grid
            //{
            //    RowSpacing = 20,
            //    ColumnSpacing = 40
            //};

            //var label = new Label { Text = "Lab 1" };
            //grid.Children.Add(label, 0, 0); //Grid.Row ="0" Grid.Column="0" or the ones commented below
            //Grid.SetRowSpan(label, 2);
            //Grid.SetColumnSpan(label, 2);
            ////Grid.SetRow(label, 0);
            ////Grid.SetColumn(label, 0);
            ////grid.Children.Add(new Label { Text = "Lab 2" };
            ////grid.Children.Add(new Label { Text = "Lab 3" };
            ////grid.Children.Add(new Label { Text = "Lab 4" };

            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(100, GridUnitType.Absolute)
            //});
            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(2, GridUnitType.Star)
            //});
            //grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(1, GridUnitType.Auto)
            //});

            
        }


    }
}
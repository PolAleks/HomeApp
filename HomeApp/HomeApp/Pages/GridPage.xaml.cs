using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            //InitializeComponent ();

            Grid grid = new Grid
            {
                // Набор строк 
                RowDefinitions =
               {
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
               },

                // Набор столбцов
                ColumnDefinitions =
               {
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
               },
                ColumnSpacing = 20,
                RowSpacing = 20
            };

            //// Добавление элементов по определенным позициям
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(250, 253, 255) }, 0 /* Позиция слева */, 0 /* Позиция сверху */);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(196, 232, 255) }, 0, 1);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 0, 2);

            //grid.Children.Add(new BoxView { Color = Color.FromRgb(87, 189, 255) }, 1, 0);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            //grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 121, 199) }, 2, 0);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 1);
            //grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 2);

            PopulateGrid(grid);

            Content = grid;
        }

        /// <summary>
        ///  Заполнение лейаута
        /// </summary>
        public void PopulateGrid(Grid grid)
        {
            var leftMergeColumn = new BoxView { Color = Color.FromRgb(133, 207, 255) };

            grid.Children.Add(leftMergeColumn, 0, 0);

            Grid.SetRowSpan(leftMergeColumn, 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(250, 253, 255) }, 1, 0);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            var rightMergeColumn = new BoxView { Color = Color.FromRgb(133, 207, 255) };
            
            grid.Children.Add(rightMergeColumn, 2, 0);

            Grid.SetRowSpan(rightMergeColumn , 3);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClimatePage : ContentPage
    {
        public ClimatePage()
        {
            InitializeComponent();

            absLayout.Children.Add(
                // Создаем прямоугольник заданного цвета
                new BoxView { Color = Color.LightBlue },
                // Задаем его местоположение и размеры
                new Rectangle(
                    20, // X - координата начальной точки
                    10, // Y - координата начальной точки
                    100, // ширина прямоугольника
                    70 // высота
                    )
                );

            absLayout.Children.Add(
                new BoxView { Color = Color.LightSalmon },
                new Rectangle(130, 10, 100, 70)
                );

        }
    }
}
using Android.InputMethodServices;
using Android.Widget;
using static Android.OS.DropBoxManager;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

namespace ExamenAPP.Droid
{

    public partial class MainPage : TabbedPage
    {
        var areaCirculoViewModel = new AreaCirculoViewModel();
        var areaRectanguloViewModel = new AreaRectanguloViewModel();

        var tabbedPage = new TabbedPage();

        var circuloPage = new ContentPage
        {
            Title = "Area del círculo",
            BindingContext = areaCirculoViewModel,
            Content = new StackLayout
            {
                Children =
        {
            new Label { Text = "Radio:" },
            new Entry { Keyboard = Keyboard.Numeric, Text = "0" }.Bind(nameof(areaCirculoViewModel.Radio)),
            new Label { Text = "Area:" },
            new Label { TextColor = Color.Green }.Bind(nameof(areaCirculoViewModel.Area)),
            new Button { Text = "Calcular", Command = new Command(() => { }) }
        }
            }
        };

        var rectanguloPage = new ContentPage
        {
            Title = "Area del rectángulo",
            BindingContext = areaRectanguloViewModel,
            Content = new StackLayout
            {
                Children =
        {
            new Label { Text = "Base:" },
            new Entry { Keyboard = Keyboard.Numeric, Text = "0" }.Bind(nameof(areaRectanguloViewModel.BaseRectangulo)),
            new Label { Text = "Altura:" },
            new Entry { Keyboard = Keyboard.Numeric, Text = "0" }.Bind(nameof(areaRectanguloViewModel.AlturaRectangulo)),
            new Label { Text = "Area:" },
            new Label { TextColor = Color.Green }.Bind(nameof(areaRectanguloViewModel.Area)),
            new Button { Text = "Calcular", Command = new Command(() => { }) }
        }
            }
        };

        tabbedPage.Children.Add(circuloPage);
        tabbedPage.Children.Add(rectanguloPage);

        Context = tabbedPage;

    }
}
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenAPP.Droid.ViewModels
{
    internal class AreaRectanguloViewModels
    {
       
            private double baseRectangulo;
            private double alturaRectangulo;
            private double area;

            public double BaseRectangulo
            {
                get => baseRectangulo;
                set
                {
                    baseRectangulo = value;
                OnPropertyChanged(nameof(BaseRectangulo));
                    CalcularArea();
                }
            }

            public double AlturaRectangulo
            {
                get => alturaRectangulo;
                set
                {
                    alturaRectangulo = value;
                OnPropertyChanged(nameof(AlturaRectangulo));
                    CalcularArea();
                }
            }

            public double Area
            {
                get => area;
                set
                {
                    area = value;
                OnPropertyChanged(nameof(Area));
                }
            }

            private void CalcularArea()
            {
                Area = BaseRectangulo * AlturaRectangulo;
            }
        

    }
}
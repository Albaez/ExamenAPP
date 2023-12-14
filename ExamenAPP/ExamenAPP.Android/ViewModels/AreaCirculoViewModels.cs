using System;

namespace ExamenAPP.Droid.ViewModels
{
    internal class AreaCirculoViewModels
    {

            private double radio;
            private double area;

            public double Radio
            {
                get => radio;
                set
                {
                    radio = value;
                OnPropertyChanged(nameof(Radio));
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
                Area = Math.PI * Math.Pow(Radio, 2);
            }
        

    }
}
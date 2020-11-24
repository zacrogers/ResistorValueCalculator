using ResistorCalculator.Models;
using ResistorCalculator.MyDataSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ResistorCalculator.ViewModels
{
    class FourBandResistorViewModel : INotifyPropertyChanged
    {
        #region Fields
        
       
        int band1Value = 0;
        int band2Value = 0;
        int multiplier = 0;
        float tolerance = 0.0f;
        /*


        Color band1Color;
        Color band2Color;
        Color band3Color;
        Color band4Color;
        */

        ResistorBand band1ItemSelected;
        ResistorBand band2ItemSelected;
        ResistorBand band3ItemSelected;
        ResistorBand band4ItemSelected;

#endregion

        #region Constructor
        public FourBandResistorViewModel()
        {
            BandValues = new ObservableCollection<ResistorBand>();
            
            MyData1 _context = new MyData1();

            foreach (var band in _context.Band1Vals)
            {
                BandValues.Add(band);
            }

            band1ItemSelected = new ResistorBand(1, Color.FromHex("#000000"), 1, 1.0f);
            band2ItemSelected = new ResistorBand(1, Color.FromHex("#000000"), 1, 1.0f);
            band3ItemSelected = new ResistorBand(1, Color.FromHex("#000000"), 1, 1.0f);
            band4ItemSelected = new ResistorBand(1, Color.FromHex("#000000"), 1, 1.0f);
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        public ObservableCollection<ResistorBand> BandValues { get; set; }
        public string CurrentResistorValue
        {
            get
            {
                int holder = 1;
                return $"{CalculateResistorValue()} \u03A9 \u00B1 {holder}%";
            }
        }

        /*
        public int Band1Value
        {
            get
            {
                return band1Value;
            }
            set
            {
                band1Value = 100;
                OnPropertyChanged("Band1Value");
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }

        public int Band2Value
        {
            get
            {
                return band2Value;
            }
            set
            {
                band2Value = value;
                OnPropertyChanged("Band2Value");
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }

        public int Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
                OnPropertyChanged("Multiplier");
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }

        public float Tolerance
        {
            get
            {
                return tolerance;
            }
            set
            {
                tolerance = value;
                OnPropertyChanged("Tolerance");
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }
        */
        public ResistorBand Band1ItemSelected
        {
            get
            {
                return band1ItemSelected;
            }
            set
            {
                band1ItemSelected = value;
                //Band1Color = Color.FromHex(band1ItemSelected.BandColour);
                //Band1Value = band1ItemSelected.BandVal;
                OnPropertyChanged("Band1ItemSelected");
                OnPropertyChanged("CurrentResistorValue");
            }
        }
        public ResistorBand Band2ItemSelected
        {
            get
            {
                return band2ItemSelected;
            }
            set
            {
                band2ItemSelected = value;
                //Band2Color = Color.FromHex(band2ItemSelected.BandColour);
                //Band2Value = band2ItemSelected.BandVal;
                OnPropertyChanged("Band2ItemSelected");
                OnPropertyChanged("CurrentResistorValue");
            }
        }
        public ResistorBand Band3ItemSelected 
        {
            get
            {
                return band3ItemSelected;
            }
            set
            {
                band3ItemSelected = value;
                //Band3Color = Color.FromHex(band3ItemSelected.BandColour);
                //Multiplier = band3ItemSelected.BandVal;
                OnPropertyChanged("Band3ItemSelected");
                OnPropertyChanged("CurrentResistorValue");
            }
        }
        public ResistorBand Band4ItemSelected
        {
            get
            {
                return band4ItemSelected;
            }
            set
            {
                band4ItemSelected = value;
                //Band4Color = Color.FromHex(band4ItemSelected.BandColour);
                //Tolerance = band4ItemSelected.BandVal;
                OnPropertyChanged("Band4ItemSelected");
                OnPropertyChanged("CurrentResistorValue");
            }
        }
        /*
        public Color Band1Color
        {
            get
            {
                return band1Color;
            }
            set
            {
                band1Color = value;
                OnPropertyChanged("Band1Color");
            }
        }
        public Color Band2Color
        {
            get 
            {
                return band2Color;
            }
            set 
            {
                band2Color = value;
                OnPropertyChanged("Band2Color");
            }
        }
        public Color Band3Color
        {
            get 
            {
                return band3Color;
            }
            set
            {
                band3Color = value;
                OnPropertyChanged("Band3Color");
            }
        }
        public Color Band4Color 
        {
            get
            {
                return band4Color;
            }
            set
            {
                band4Color = value;
                OnPropertyChanged("Band4Color");
            }
        }
        */
        #endregion

        #region Methods
        //void OnPropertyChanged([CallerMemberName] string name = "")
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /*
        public void Band1ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ResistorBand)e.SelectedItem;
            Band1Color = Color.FromHex(item.BandColour);
        }
        public void Band2ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ResistorBand)e.SelectedItem;
            Band1Color = Color.FromHex(item.BandColour);
        }

        public void Band3ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ResistorBand)e.SelectedItem;
            Band1Color = Color.FromHex(item.BandColour);
        }

        public void Band4ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ResistorBand)e.SelectedItem;
            Band1Color = Color.FromHex(item.BandColour);
        }
        */
        private string CalculateResistorValue()
        {
            /*
            int b1 = band1ItemSelected.BandVal;
            int b2 = band2ItemSelected.BandVal;
            int mult = band3ItemSelected.BandVal;
            */
            int b1 = 1;
            int b2 = 1;
            int mult = 1;

            float resistorVal = (((b1 * 10.0f) + b2) / 10.0f) * (float)Math.Pow(10, mult);
            string returnString = string.Empty;

            if (resistorVal < 1000)
            {
                returnString = $"{resistorVal}";
            }
            /* Giga ohms */
            else if (resistorVal > 999999999)
            {
                returnString = $"{resistorVal / 1000000000} G";
            }
            /* Mega ohms */
            else if (resistorVal > 999999)
            {
                returnString = $"{resistorVal / 1000000} M";
            }
            /* Kilo ohms */
            else if (resistorVal > 999)
            {
                returnString = $"{resistorVal / 1000} k";
            }
            return returnString;
        }
        #endregion
    }
}

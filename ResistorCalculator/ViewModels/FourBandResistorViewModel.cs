﻿using ResistorCalculator.Models;
using ResistorCalculator.MyDataSource;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ResistorCalculator.ViewModels
{
    class FourBandResistorViewModel : INotifyPropertyChanged
    {
        #region Fields

        int   band1Value = 0;
        int   band2Value = 0;
        int   multiplier = 0;
        float tolerance  = 0.0f;
        
        ResistorBand band1ItemSelected;
        ResistorBand band2ItemSelected;
        ResistorBand band3ItemSelected;
        ResistorBand band4ItemSelected;

        #endregion

        #region Constructor
        public FourBandResistorViewModel()
        {
            BandValues = new ObservableCollection<ResistorBand>();
            ToleranceBand = new ObservableCollection<ResistorBand>();

            MyData1 _context = new MyData1();

            foreach (var band in _context.Band1Vals)
            {
                // Exclude silver and gold bands
                if (!band.Color.Equals("#FFFFD700") && !band.Color.Equals("#c0c0c0"))
                {
                    BandValues.Add(band);
                }

                // Exclude black and white bands
                if(!band.Color.Equals("#000000") && !band.Color.Equals("#FFFFFF"))
                {
                    ToleranceBand.Add(band);
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        public ObservableCollection<ResistorBand> BandValues { get; set; }
        public ObservableCollection<ResistorBand> ToleranceBand { get; set; }

        public string CurrentResistorValue
        {
            get{ return $"{CalculateResistorValue()} \u03A9 \u00B1 {tolerance}%"; }
        }

        public ResistorBand Band1ItemSelected
        {
            get{ return band1ItemSelected; }

            set
            {
                band1ItemSelected = value;
                OnPropertyChanged("Band1ItemSelected");

                if(band1ItemSelected != null)
                {
                    band1Value = band1ItemSelected.BandVal;
                    OnPropertyChanged("CurrentResistorValue");
                }
            }
        }

        public ResistorBand Band2ItemSelected
        {
            get{ return band2ItemSelected; }

            set
            {
                band2ItemSelected = value;
                OnPropertyChanged("Band2ItemSelected");

                if (band2ItemSelected != null)
                {
                    band2Value = band2ItemSelected.BandVal;
                    OnPropertyChanged("CurrentResistorValue");
                }
            }
        }

        public ResistorBand Band3ItemSelected 
        {
            get{ return band3ItemSelected; }

            set
            {
                band3ItemSelected = value;
                OnPropertyChanged("Band3ItemSelected");

                if (band3ItemSelected != null)
                {
                    multiplier = band3ItemSelected.BandVal;
                    OnPropertyChanged("CurrentResistorValue");
                }
            }
        }

        public ResistorBand Band4ItemSelected
        {
            get{ return band4ItemSelected; }

            set
            {
                band4ItemSelected = value;
                OnPropertyChanged("Band4ItemSelected");

                if (band4ItemSelected != null)
                {
                    tolerance = band4ItemSelected.Tolerance;
                    OnPropertyChanged("CurrentResistorValue");
                }
            }
        }
        #endregion

        #region Methods
        //void OnPropertyChanged([CallerMemberName] string name = "")
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string CalculateResistorValue()
        {            
            int b1 = band1Value;
            int b2 = band2Value;
            int mult = multiplier;

            float resistorVal = ((b1 * 10.0f) + b2) * (float)Math.Pow(10, mult);
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

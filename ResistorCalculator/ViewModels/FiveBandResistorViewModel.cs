using ResistorCalculator.Models;
using ResistorCalculator.MyDataSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ResistorCalculator.ViewModels
{
    class FiveBandResistorViewModel : INotifyPropertyChanged
    {
        public int band1Value = 0;
        public int band2Value = 0;
        public int band3Value = 0;
        public int multiplier = 0;
        public float tolerance = 0.0f;

        public FiveBandResistorViewModel()
        {
            BandValues = new ObservableCollection<ResistorBand>();
            /* 
             * TODO : add resistor band values
             */
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        public ObservableCollection<ResistorBand> BandValues { get; set; }
        public string CurrentResistorValue 
        {
            get
            {
                return $"{CalculateResistorValue()} \u03A9 \u00B1 {Tolerance}%";
            }
        }
        public int Band1Value 
        { 
            get
            {
                return band1Value;
            }
            set
            {
                band1Value = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }
        public int Band3Value 
        {
            get
            {
                return band3Value;
            }
            set
            {
                band3Value = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
                OnPropertyChanged(nameof(CurrentResistorValue));
            }
        }
        #endregion

        #region Methods
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string CalculateResistorValue()
        {
            float resistorVal = (((band1Value * 100.0f) + (band2Value + 10.0f) + band3Value) / 100.0f) * (float)Math.Pow(10, multiplier);
            string returnString = string.Empty;

            if(resistorVal < 1000)
            {
                returnString = $"{resistorVal}";
            }
            /* Giga ohms */
            else if(resistorVal > 999999999)
            {
                returnString = $"{resistorVal / 1000000000} G";
            }
            /* Mega ohms */
            else if(resistorVal > 999999)
            {
                returnString = $"{resistorVal / 1000000} M";
            }
            /* Kilo ohms */
            else if(resistorVal > 999)
            {
                returnString = $"{resistorVal / 1000} k";
            }
            return returnString;
        }
        #endregion
    }
}

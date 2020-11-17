using ResistorCalculator.Models;
using ResistorCalculator.MyDataSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ResistorCalculator.ViewModels
{
    class ResistorBandViewModel
    {
        private ObservableCollection<ResistorBand> values;

        public ObservableCollection<ResistorBand> Values
        {
            get { return values; }
            set
            {
                values = value;
            }
        }

        public ResistorBandViewModel()
        {
            Values = new ObservableCollection<ResistorBand>();

            MyData1 _context = new MyData1();

            foreach(var band in _context.Band1Vals)
            {
                Values.Add(band);
            }


        }
    }
}

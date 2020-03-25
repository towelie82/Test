using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemo.Behavior.Models;

namespace XamarinDemo.Behavior.ViewModels
{
    public class MaskedEntryViewModel : ViewModelBase
    {
        public IList<Country> Countries { get { return CountryData.Countries; } }
        Country selectedCountry;
        public Country SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                if (selectedCountry != value)
                {
                    selectedCountry = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}

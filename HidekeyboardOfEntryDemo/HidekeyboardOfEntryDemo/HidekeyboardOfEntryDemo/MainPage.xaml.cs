using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HidekeyboardOfEntryDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Person> _list { get; set; }
        public MainPage()
        {
            InitializeComponent();
            _list = new ObservableCollection<Person>()
            {
                new Person(){Id ="0"},
                new Person(){Id ="1"}
            };

            this.BindingContext = this;
        }

        private void AddMore_Tapped(object sender, EventArgs e)
        {
            _list.Add(new Person() { Id = "1" });
        }
    }
    public class Person : INotifyPropertyChanged
    {
        private string _Id;
        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

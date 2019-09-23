using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CaseDemo.MultipleSubuser.ViewModel
{
    public class ProfilerViewModel : INotifyPropertyChanged
    {
        public string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string _UserName;
        public string UserName
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string _Detail1;
        public string Detail1
        {
            get
            {
                return _Detail1;
            }
            set
            {
                if (_Detail1 != value)
                {
                    _Detail1 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string _Detail2;
        public string Detail2
        {
            get
            {
                return _Detail2;
            }
            set
            {
                if (_Detail2 != value)
                {
                    _Detail2 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string _Detail3;
        public string Detail3
        {
            get
            {
                return _Detail3;
            }
            set
            {
                if (_Detail3 != value)
                {
                    _Detail3 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string _Detail4;



        public string Detail4
        {
            get
            {
                return _Detail4;
            }
            set
            {
                if (_Detail4 != value)
                {
                    _Detail4 = value;
                    NotifyPropertyChanged();
                }
            }
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    //{
    //    List<Subuser> subusers;
    //   public Subuser Subuser { get; }
    //    public ProfilerViewModel()
    //    {
    //        Subuser = new Subuser
    //        {
    //            Name = "Sub User1",
    //            Detail1 = "Details1",
    //            Detail2 = "Details2",
    //            Detail3 = "Details3",
    //            Detail4 = "Details4"
    //        };
    //    }

    //}
}

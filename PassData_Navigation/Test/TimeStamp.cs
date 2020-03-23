using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinDemo.PassingData_Navigating.Test
{
    public class TimeStamp
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    //private string _startTime;
    //public string StartTime
    //{
    //    get
    //    {
    //        return _startTime;
    //    }
    //    set
    //    {
    //        _startTime = value;
    //        OnPropertyChanged("StartTime");
    //    }
    //}
    //private string _endTime;
    //public string EndTime
    //{
    //    get
    //    {
    //        return _endTime;
    //    }
    //    set
    //    {
    //        _endTime = value;
    //        OnPropertyChanged("EndTime");
    //    }
    //}

    //public event PropertyChangedEventHandler PropertyChanged;

    //protected virtual void OnPropertyChanged(string propertyName)
    //{
    //    if (PropertyChanged != null)
    //    {
    //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

}

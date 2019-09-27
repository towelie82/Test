using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewBindng.ViewModel
{
    public class ParentItems : ObservableCollection<ChildItems>
    {
        public string ID { get; set; }
        public string Title { get; set; }


        public ParentItems(List<ChildItems> list) : base(list)
        {

        }
    }
}

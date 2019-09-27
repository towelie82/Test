using ListViewBindng.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewBindng.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NestedListViewPage : ContentPage
    {
        public ObservableCollection<ParentItems> parentItems { get; set; }
        public ObservableCollection<ChildItems> childItems { get; set; }
        public NestedListViewPage()
        {
            InitializeComponent();
            listView.ItemsSource = GetData();
        }

        public List<ParentItems> GetData()
        {

            childItems = new ObservableCollection<ChildItems>
          {
              new ChildItems{ ChildTitle="Chlild-A", Description="aaa" },
              new ChildItems{ ChildTitle="Chlild-B", Description="bbb" },
              new ChildItems{ ChildTitle="Chlild-C", Description="ccc" },
              new ChildItems{ ChildTitle="Chlild-D", Description="ddd" }
          };
            List<ParentItems> parentItems = new List<ParentItems>()
            {
                new ParentItems(childItems.ToList()){ID="1", Title="A"},
                new ParentItems(childItems.ToList()){ID="2", Title="B"},
                new ParentItems(childItems.ToList()){ID="3", Title="C"},
                new ParentItems(childItems.ToList()){ID="4", Title="D"},

            };

            return parentItems;





        }
    }
}
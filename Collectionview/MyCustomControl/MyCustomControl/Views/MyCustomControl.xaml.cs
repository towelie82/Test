using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCustomControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomControl : ContentView
    {
        public ObservableCollection<model> models { get; set; }
        public MyCustomControl()
        {
            InitializeComponent();
            models = new ObservableCollection<model>()
            {
                new model(){id=1,name="test", image="tab_graph.png"},
                 new model(){id=2,name="test", image="tab_graph.png"},
                  new model(){id=3,name="test", image="tab_graph.png" },
                   new model(){id=4,name="test", image="tab_graph.png"},
                    new model(){id=5,name="test", image="tab_graph.png"},
                     new model(){id=6,name="test", image="tab_graph.png"},
                      new model(){id=7,name="test", image="tab_graph.png" },
                       new model(){id=8,name="test", image="tab_graph.png"},
                        new model(){id=9,name="test", image="tab_graph.png"},
                        new model(){id=10,name="test", image="tab_graph.png"},
                        new model(){id=11,name="test", image="tab_graph.png"},
                 new model(){id=12,name="test", image="tab_graph.png"},
                  new model(){id=13,name="test", image="tab_graph.png" },
                   new model(){id=14,name="test", image="tab_graph.png"},
                    new model(){id=15,name="test", image="tab_graph.png"},
                     new model(){id=16,name="test", image="tab_graph.png"},
                      new model(){id=17,name="test", image="tab_graph.png" },
                       new model(){id=18,name="test", image="tab_graph.png"},
                        new model(){id=19,name="test", image="tab_graph.png"}
            };
            this.BindingContext = this;
        }

    }

    public class model
    {
        public string name { get; set; }
        public string image { get; set; }
        public int id { get; set; }
    }
}
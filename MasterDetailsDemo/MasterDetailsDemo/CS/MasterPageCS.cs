using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class MasterPageCS : ContentPage
    {
        public ListView ListView { get { return listView; } }
        ListView listView;
        public MasterPageCS()
        {
            var masterPageItems = new ObservableCollection<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Id = 0,
                Title = "Client Info",
                IconSource = "icon.png",
                TargetType = typeof(ClientInfoPageCS)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Id = 1,
                Title = "Logout",
                IconSource = "icon.png",
                TargetType = typeof(LogoutPageCS)
            }); ;
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About",
                IconSource = "icon.png",
                TargetType = typeof(AboutPageCS)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };

            IconImageSource = "icon.png";
            Title = "Personal Organiser";
            Padding = new Thickness(0, 40, 0, 0);
            Content = new StackLayout
            {
                Children = { listView }
            };

        }
    }
}

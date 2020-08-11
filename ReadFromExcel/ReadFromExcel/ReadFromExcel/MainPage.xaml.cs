using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadFromExcel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var list = new List<test>();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ReadFromExcel.test.csv";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                //string result = reader.ReadToEnd();

                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            list.Add(new test
                            {
                                ID = csv.GetField<string>(0),
                                Name = csv.GetField<string>(1),
                                Age = csv.GetField<string>(2)
                            });
                        }
                    }
                }

            }
            label.Text = (list.ToArray())[5].ID;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
    public class test
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}

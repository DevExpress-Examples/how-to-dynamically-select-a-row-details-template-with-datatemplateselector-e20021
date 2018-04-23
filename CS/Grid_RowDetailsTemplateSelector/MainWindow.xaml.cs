using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Grid_RowDetailsTemplateSelector
{
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Person.GetData();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public static List<Person> GetData() {
            List<Person> data = new List<Person>();
            data.Add(new Person() { FirstName = "Lara", LastName = "Pembridge", Address = "14 Aldgate, London", PhoneNumber = "+44 3069 990173" });
            data.Add(new Person() { FirstName = "Chris", LastName = "Christensen", Address = "2 High Holborn, London", PhoneNumber = "+44 3069 990032" });
            data.Add(new Person() { FirstName = "Sam", LastName = "Darlington", Address = "Hans-Grade-Allee 25, Damsdorf", PhoneNumber = "04557 66 08 94" });
            data.Add(new Person() { FirstName = "Jessy", LastName = "Oldridge", Address = "An Der Urania 77, Aichstetten", PhoneNumber = "04841 96 66 74" });
            return data;
        }
    }
}

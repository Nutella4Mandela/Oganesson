using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Diagnostics.Tracing;

namespace Og
{

    public partial class Organize : UserControl
    {
     
        public Organize()
        {
            InitializeComponent();
            ColorList.ItemsSource = typeof(Colors).GetProperties();
            
        }
        public string name = "";
        private void Adder_Click(object sender, RoutedEventArgs e)
        {
            Wrapper.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Hidden;
            Inventory.Visibility = Visibility.Hidden;

            BoxMaker.Visibility = Visibility.Visible;
            Color.Visibility = Visibility.Visible;
            Namer.Visibility = Visibility.Visible;
            ColorList.Visibility = Visibility.Visible;
            Name.Visibility = Visibility.Visible;
            Make.Visibility = Visibility.Visible;

        }
     
        private void ColorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Make_Click(object sender, RoutedEventArgs e)
        {
            Color selectedColor = (Color)(ColorList.SelectedItem as PropertyInfo).GetValue(null, null); ;
            Button CreatedButton = new Button();
            name = Name.Text;
            CreatedButton.Name = name;
            CreatedButton.Content = name;
            CreatedButton.Width = 112;
            CreatedButton.Height = 60;
            CreatedButton.Background = new SolidColorBrush(selectedColor);
            Wrapper.Children.Add(CreatedButton);
            CreatedButton.Click += Button_Click;

            WrapPanel CreatedWrap = new WrapPanel();
            ListBox CreatedList = new ListBox();

            
            CreatedWrap.Name = name;

            CreatedList.Name = name;
            CreatedList.Width = 800;
            CreatedList.Height = 500;
            CreatedWrap.Width = 800;
            CreatedWrap.Height = 500;


            CreatedWrap.Children.Add(CreatedList);

            

            CreatedWrap.Visibility = Visibility.Visible;
            CreatedList.Visibility = Visibility.Visible;
            Wrapper.Visibility = Visibility.Visible;
            Back.Visibility = Visibility.Visible;
            Inventory.Visibility = Visibility.Visible;

            BoxMaker.Visibility = Visibility.Hidden;
            Color.Visibility = Visibility.Hidden;
            Namer.Visibility = Visibility.Hidden;
            ColorList.Visibility = Visibility.Hidden;
            Name.Visibility = Visibility.Hidden;
            Make.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Wrapper.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Hidden;
            Inventory.Visibility = Visibility.Hidden;

        }
    }
}

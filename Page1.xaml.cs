using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
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

namespace Og
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ADDList_Click(object sender, RoutedEventArgs e)
        {
            LBX1.Items.Add(TBX1.Text);
        }

        private void DEList_Click(object sender, RoutedEventArgs e)
        {
            if (LBX1.SelectedItems != null)
            {
                LBX1.Items.Remove(LBX1.SelectedItem);
            }
        }

        private void LBX1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}

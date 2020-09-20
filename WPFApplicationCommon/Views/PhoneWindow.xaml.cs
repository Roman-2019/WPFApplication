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
using WPFApplicationCommon.Models;

namespace WPFApplicationCommon.Views
{
    public partial class PhoneWindow : Window
    {
        public Phone PhoneModel { get; private set; }

        public PhoneWindow(Phone p)
        {
            InitializeComponent();
            PhoneModel = p;
            this.DataContext = PhoneModel;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

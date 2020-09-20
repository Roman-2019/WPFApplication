using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplicationCommon.Models
{
    public class Phone : INotifyPropertyChanged
    {
        private string title;
        private string category;
        private int price;
        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged("Category");
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
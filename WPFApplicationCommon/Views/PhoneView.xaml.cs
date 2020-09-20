using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public partial class PhoneView : UserControl
    {
        MobileContext db;
        //IUnityContainer container = new UnityContainer();

        public PhoneView()
        {
            InitializeComponent();

            db = new MobileContext();
            db.Phones.Load(); 
            phonesGrid.ItemsSource = db.Phones.Local.ToBindingList();

            //this.Closing += MainWindow_Closing;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //container.RegisterType<IPhone, Phone>();

            PhoneWindow phoneWindow = new PhoneWindow(new Phone());//container.Resolve<PhoneWindow>();//
            if (phoneWindow.ShowDialog() == true)
            {
                Phone phone = phoneWindow.PhoneModel;
                db.Phones.Add(phone);
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            
            if (phonesGrid.SelectedItem == null) return;
            Phone phone = phonesGrid.SelectedItem as Phone;

            PhoneWindow phoneWindow = new PhoneWindow(new Phone
            {
                Id = phone.Id,
                Category = phone.Category,
                Price = phone.Price,
                Title = phone.Title
            });

            if (phoneWindow.ShowDialog() == true)
            {
                phone = db.Phones.Find(phoneWindow.PhoneModel.Id);
                if (phone != null)
                {
                    phone.Category = phoneWindow.PhoneModel.Category;
                    phone.Title = phoneWindow.PhoneModel.Title;
                    phone.Price = phoneWindow.PhoneModel.Price;
                    db.Entry(phone).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e) 
        {
            db = new MobileContext();
            db.Phones.Load();

            if (cmbCategory.SelectedIndex != 2)
            {
                if (cmbCategory.SelectedIndex == 1)
                {
                    phonesGrid.ItemsSource = db.Phones.Local.ToBindingList().Where(x => x.Category == "Stationary");
                }
                else 
                {
                    phonesGrid.ItemsSource = db.Phones.Local.ToBindingList().Where(x => x.Category == "Mobile");
                }
            }
            else 
            {
                phonesGrid.ItemsSource = db.Phones.Local.ToBindingList();
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    Phone phone = phonesGrid.SelectedItems[i] as Phone;
                    if (phone != null)
                    {
                        db.Phones.Remove(phone);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace FitnessClubApp
{
    internal class UserViewModel : DependencyObject
    {
        public UserViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(User.GetUsers());
        }
        public string CheckText
        {
            get { return (string)GetValue(CheckTextProperty); }
            set { SetValue(CheckTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckTextProperty =
            DependencyProperty.Register("CheckText", typeof(string), typeof(UserViewModel), new PropertyMetadata(""));



        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(UserViewModel), new PropertyMetadata(""));



        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(UserViewModel), new PropertyMetadata(null));


    }
}

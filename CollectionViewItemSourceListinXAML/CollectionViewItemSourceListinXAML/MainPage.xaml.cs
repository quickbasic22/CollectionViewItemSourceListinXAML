using CollectionViewItemSourceObservableCollectioninXAML.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewItemSourceListinXAML
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string name;
        private string location;
        private string imageurl;

        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Location
        { 
            get
            {
                return location;
            }
            set
            {
                location = value;
                OnPropertyChanged();
            }
        }
        public string ImageUrl 
        {
            get
            {
                return imageurl;
            }
            set
            {
                imageurl = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            // for codebehind databinding instead of XAML List<Monkey> binding
            //BindingContext = Monkey.GetMonkey();
        }
    }
}

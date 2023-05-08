using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
            {
            new Group("A")
            {
                new Item { Title = "Arce", Subtitle = "Pepe" },
                new Item { Title = "Aranda", Subtitle = "Martin" },
                new Item { Title = "Alarcon", Subtitle = "Daniel" },
                new Item { Title = "Aguila", Subtitle = "Joaquin" }
            },
            new Group("B")
            {
                new Item { Title = "Barrios", Subtitle = "Lolo" },
                new Item { Title = "Bendezu", Subtitle = "Fatima" },
                new Item { Title = "Bolaños", Subtitle = "Luciana" },
                new Item { Title = "Besos", Subtitle = "Jeff" }
            },
            new Group("C")
            {
                new Item { Title = "Caceres", Subtitle = "Pablo" },
                new Item { Title = "Colinas", Subtitle = "Marcelo" },
                new Item { Title = "Chamorro", Subtitle = "Hameth" },
                new Item { Title = "Chipana", Subtitle = "Erick" }
            },
            };
            GroupedView.ItemsSource = Groups;
        }
    }
}
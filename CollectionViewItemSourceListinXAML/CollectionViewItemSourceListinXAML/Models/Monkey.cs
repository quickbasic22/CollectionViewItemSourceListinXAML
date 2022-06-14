using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Web;

namespace CollectionViewItemSourceObservableCollectioninXAML.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public Monkey()
        {
            this.Name = "Blue Monkey";
            this.Location = "Central and East Africa";
            this.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg";
        }
        public Monkey(string name, Monkey monkey)
        {
            this.Name = monkey.Name;
            this.Location = monkey.Location;
            this.ImageUrl = monkey.ImageUrl;
        }
        public Monkey(string name, string location, string imageurl)
        {
            this.Name = name;
            this.Location = location;
            this.ImageUrl = imageurl;
        }

        public static ObservableCollection<Monkey> GetMonkey()
        {
            ObservableCollection<Monkey> Monkeys = new ObservableCollection<Monkey>
            {
              new Monkey() { Name = "Baboon", Location = "Africa and Asia", ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg" },
              new Monkey() { Name = "Capuchin Monkey", Location = "Central and South America", ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg" },
              new Monkey() { Name = "Blue Monkey", Location = "Central and East Africa", ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg" }
            };
            return Monkeys;
        }
    }
}

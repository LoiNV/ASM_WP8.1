using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GameForKids.DataModel;

namespace GameForKids.DataModel
{
    public class Groups
    {
        public string Name { get; set; }
        public ObservableCollection<Items> Item { get; set; }

        public Groups(string name) {
            this.Name = name;
            this.Item = new ObservableCollection<Items>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameForKids.DataModel;
using System.Collections.ObjectModel;
using Windows.Storage;
using System.IO;
using System.Runtime.Serialization.Json;

namespace GameForKids.ViewModel
{
    public class MainViewModel
    {
        public Groups Animals { get; set; }
        public Groups Cartoons { get; set; }
        public Groups Taunts { get; set; }
        public Groups Warnings { get; set; }

        public MainViewModel() {
            
            //Animals
            ObservableCollection<Items> listAnimals = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="ms-appx:///Assets/Images/Animals/CatKitten.jpg", MediaPath= "ms-appx:///Assets/Audio/Animals/CatKitten.wav"},
                new Items(){Name="CatMeow", ImagePath="ms-appx:///Assets/Images/Animals/CatMeow.jpg", MediaPath= "ms-appx:///Assets/Audio/Animals/CatMeow.wav"},
                new Items(){Name="Chimpanzee", ImagePath="ms-appx:///Assets/Images/Animals/Chimpanzee.jpg", MediaPath= "ms-appx:///Assets/Audio/Animals/Chimpanzee.wav"},
                new Items(){Name="Cow", ImagePath="ms-appx:///Assets/Images/Animals/Cow.jpg", MediaPath= "ms-appx:///Assets/Audio/Animals/Cow.wav"}
            };
            this.Animals = new Groups("Animals") { Item = listAnimals };

            //Cartoons
            ObservableCollection<Items> listCartoons = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="ms-appx:///Assets/Images/Cartoons/Boing.jpg", MediaPath= "ms-appx:///Assets/Audio/Cartoons/Boing.wav"},
                new Items(){Name="CatMeow", ImagePath="ms-appx:///Assets/Images/Cartoons/Splat.jpg", MediaPath= "ms-appx:///Assets/Audio/Cartoons/Splat.wav"},
                new Items(){Name="Chimpanzee", ImagePath="ms-appx:///Assets/Images/Cartoons/Buglecharge.jpg", MediaPath= "ms-appx:///Assets/Audio/Cartoons/Buglecharge.wav"},
                new Items(){Name="Cow", ImagePath="ms-appx:///Assets/Images/Cartoons/Laser.jpg", MediaPath= "ms-appx:///Assets/Audio/Cartoons/Laser.wav"}
            };
            this.Cartoons = new Groups("Cartoons") {Item= listCartoons };
            
            //Taunts
            ObservableCollection<Items> listTaunts = new ObservableCollection<Items>(){
                new Items(){Name="Cackle", ImagePath="ms-appx:///Assets/Images/Taunts/Cackle.jpg", MediaPath= "ms-appx:///Assets/Audio/Taunts/Cackle.wav"},
                new Items(){Name="Clock Ticking", ImagePath="ms-appx:///Assets/Images/Taunts/ClockTicking.jpg", MediaPath= "ms-appx:///Assets/Audio/Taunts/ClockTicking.wav"},
                new Items(){Name="Dial up", ImagePath="ms-appx:///Assets/Images/Taunts/Dialup.jpg", MediaPath= "ms-appx:///Assets/Audio/Taunts/Dialup.wav"},
                new Items(){Name="Drum roll", ImagePath="ms-appx:///Assets/Images/Taunts/Drumroll.jpg", MediaPath= "ms-appx:///Assets/Audio/Taunts/Drumroll.wav"}
            };
            this.Taunts = new Groups("Taunts") { Item = listTaunts };

            //Warnings
            ObservableCollection<Items> listWarnings = new ObservableCollection<Items>(){
                new Items(){Name="Air horn", ImagePath="ms-appx:///Assets/Images/Warnings/Airhorn.jpg", MediaPath= "ms-appx:///Assets/Audio/Warnings/Airhorn.wav"},
                new Items(){Name="Air Raid", ImagePath="ms-appx:///Assets/Images/Warnings/AirRaid.jpg", MediaPath= "ms-appx:///Assets/Audio/Warnings/AirRaid.wav"},
                new Items(){Name="Alarm Clock - Bell", ImagePath="ms-appx:///Assets/Images/Warnings/AlarmClock-Bell.jpg", MediaPath= "ms-appx:///Assets/Audio/Warnings/AlarmClock-Bell.wav"},
                new Items(){Name="Alarm Clock - Electric", ImagePath="ms-appx:///Assets/Images/Warnings/AlarmClock-Electric.jpg", MediaPath= "ms-appx:///Assets/Audio/Warnings/AlarmClock-Electric.wav"}
            };
            this.Warnings = new Groups("Warnings") { Item = listWarnings };
        }
       
    }
}

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PivotApp1.Resources;
using PivotApp1.Model;

namespace PivotApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public Groups Animals { get; set; }
        public Groups Cartoons { get; set; }
        public Groups Taunts { get; set; }
        public Groups Warnings { get; set; }

        public MainViewModel()
        {

            //Animals
            ObservableCollection<Items> listAnimals = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="/Assets/Images/Animals/CatKitten.jpg", MediaPath= "/Assets/Audio/Animals/CatKitten.wav"},
                new Items(){Name="CatMeow", ImagePath="/Assets/Images/Animals/CatMeow.jpg", MediaPath= "/Assets/Audio/Animals/CatMeow.wav"},
                new Items(){Name="Chimpanzee", ImagePath="/Assets/Images/Animals/Chimpanzee.jpg", MediaPath= "/Assets/Audio/Animals/Chimpanzee.wav"},
                new Items(){Name="Cow", ImagePath="/Assets/Images/Animals/Cow.jpg", MediaPath= "/Assets/Audio/Animals/Cow.wav"}
            };
            this.Animals = new Groups("Animals") { Item = listAnimals };

            //Cartoons
            ObservableCollection<Items> listCartoons = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="/Assets/Images/Cartoons/Boing.jpg", MediaPath= "/Assets/Audio/Cartoons/Boing.wav"},
                new Items(){Name="CatMeow", ImagePath="/Assets/Images/Cartoons/Splat.jpg", MediaPath= "/Assets/Audio/Cartoons/Splat.wav"},
                new Items(){Name="Chimpanzee", ImagePath="/Assets/Images/Cartoons/Buglecharge.jpg", MediaPath= "/Assets/Audio/Cartoons/Buglecharge.wav"},
                new Items(){Name="Cow", ImagePath="/Assets/Images/Cartoons/Laser.jpg", MediaPath= "/Assets/Audio/Cartoons/Laser.wav"}
            };
            this.Cartoons = new Groups("Cartoons") { Item = listCartoons };

            //Taunts
            ObservableCollection<Items> listTaunts = new ObservableCollection<Items>(){
                new Items(){Name="Cackle", ImagePath="/Assets/Images/Taunts/Cackle.jpg", MediaPath= "/Assets/Audio/Taunts/Cackle.wav"},
                new Items(){Name="Clock Ticking", ImagePath="/Assets/Images/Taunts/ClockTicking.jpg", MediaPath= "/Assets/Audio/Taunts/ClockTicking.wav"},
                new Items(){Name="Dial up", ImagePath="/Assets/Images/Taunts/Dialup.jpg", MediaPath= "/Assets/Audio/Taunts/Dialup.wav"},
                new Items(){Name="Drum roll", ImagePath="/Assets/Images/Taunts/Drumroll.jpg", MediaPath= "/Assets/Audio/Taunts/Drumroll.wav"}
            };
            this.Taunts = new Groups("Taunts") { Item = listTaunts };

            //Warnings
            ObservableCollection<Items> listWarnings = new ObservableCollection<Items>(){
                new Items(){Name="Air horn", ImagePath="/Assets/Images/Warnings/Airhorn.jpg", MediaPath= "/Assets/Audio/Warnings/Airhorn.wav"},
                new Items(){Name="Air Raid", ImagePath="/Assets/Images/Warnings/AirRaid.jpg", MediaPath= "/Assets/Audio/Warnings/AirRaid.wav"},
                new Items(){Name="Alarm Clock - Bell", ImagePath="/Assets/Images/Warnings/AlarmClock-Bell.jpg", MediaPath= "/Assets/Audio/Warnings/AlarmClock-Bell.wav"},
                new Items(){Name="Alarm Clock - Electric", ImagePath="/Assets/Images/Warnings/AlarmClock-Electric.jpg", MediaPath= "/Assets/Audio/Warnings/AlarmClock-Electric.wav"}
            };
            this.Warnings = new Groups("Warnings") { Item = listWarnings };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
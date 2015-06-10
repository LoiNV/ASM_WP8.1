using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PivotApp1.Resources;
using PivotApp1.Model;
using Windows.Storage;
using System.Collections.Generic;
using Windows.ApplicationModel;
using System.Threading.Tasks;

namespace PivotApp1.ViewModels
{
    public class MainViewModel
    {
        public Groups Animals { get; set; }
        public Groups Cartoons { get; set; }
        public Groups Taunts { get; set; }
        public Groups Warnings { get; set; }

        public MainViewModel()
        {
            //Animals
            LoadGroupAnimals();

            //Cartoons
            LoadGroupCartoons();

            //Taunts
            LoadGroupTaunts();

            //Warnings
            LoadGroupWarnings();

            //LoadGroup();
        }


        public void AddItems(List<Items> list, string itemName, string groupName)
        {
            Items item = new Items()
            {
                Name = itemName,
                ImagePath = "/Assets/Images/" + groupName + "/" + itemName + ".jpg",
                MediaPath = "/Assets/Audio/" + groupName + "/" + itemName + ".wav"
            };
            list.Add(item);
        }

        public void LoadGroupAnimals()
        {
            List<Items> list = new List<Items>();
            AddItems(list, "CatKitten", "Animals");
            AddItems(list, "CatMeow", "Animals");
            AddItems(list, "ChimPanzee", "Animals");
            AddItems(list, "Cow", "Animals");
            AddItems(list, "Crickets", "Animals");
            AddItems(list, "Dog", "Animals");
            AddItems(list, "Dolphin", "Animals");
            AddItems(list, "Duck", "Animals");
            AddItems(list, "HorseGallop", "Animals");
            AddItems(list, "HorseWalk", "Animals");
            AddItems(list, "Lion", "Animals");
            AddItems(list, "Pig", "Animals");
            AddItems(list, "Rooster", "Animals");
            AddItems(list, "Sheep", "Animals");

            this.Animals = new Groups("Animals") { Item = list };
        }

        public void LoadGroupCartoons()
        {
            List<Items> list = new List<Items>();
            AddItems(list, "Boing", "Cartoons");
            AddItems(list, "Bronk", "Cartoons");
            AddItems(list, "Buglecharge", "Cartoons");
            AddItems(list, "Laser", "Cartoons");
            AddItems(list, "OutHere", "Cartoons");
            AddItems(list, "Splat", "Cartoons");

            this.Cartoons = new Groups("Cartoons") { Item = list };
        }

        public void LoadGroupTaunts()
        {
            List<Items> list = new List<Items>();
            AddItems(list, "Cackle", "Taunts");
            AddItems(list, "ClockTicking", "Taunts");
            AddItems(list, "Dialup", "Taunts");
            AddItems(list, "Drumroll", "Taunts");
            AddItems(list, "ElevatorMusic", "Taunts");
            AddItems(list, "Laugh-Evil", "Taunts");

            this.Taunts = new Groups("Taunts") { Item = list };
        }

        public void LoadGroupWarnings()
        {
            List<Items> list = new List<Items>();
            AddItems(list, "Airhorn", "Warnings");
            AddItems(list, "AirRaid", "Warnings");
            AddItems(list, "AlarmClock-Bell", "Warnings");
            AddItems(list, "AlarmClock-Electric", "Warnings");
            AddItems(list, "Backingup", "Warnings");
            AddItems(list, "Bell-Church", "Warnings");
            AddItems(list, "Bell-School", "Warnings");
            AddItems(list, "Foghorn", "Warnings");
            AddItems(list, "Glassbreaking", "Warnings");
            AddItems(list, "MissleAlert", "Warnings");
            AddItems(list, "Police-UK", "Warnings");
            AddItems(list, "Police-US", "Warnings");
            AddItems(list, "Vuvuzela", "Warnings");

            this.Warnings = new Groups("Warnings") { Item = list };
        }

        //public async Task<List<Items>> LoadItems(string groupName)
        //{            

        //    var folder = await Package.Current.InstalledLocation.GetFolderAsync("Assets/Images/"+ groupName);
        //    var files = await folder.GetFilesAsync();

        //    return (files.Select(
        //        (f, i) => new Items()
        //        {
        //            Name = f.Name,
        //            ImagePath = f.Path,
        //            MediaPath = f.Path.Replace(".jpg", ".wav")
        //        }).ToList());
        //}

        //public async void LoadGroup() { 

        //    this.Animals = new Groups("Animals"){Item = await LoadItems("Animals")};
        //    this.Cartoons = new Groups("Cartoons") { Item = await LoadItems("Cartoons") };
        //    this.Taunts = new Groups("Taunts") { Item = await LoadItems("Taunts") };
        //    this.Warnings = new Groups("Warnings") { Item = await LoadItems("Warnings") };
        //}
        
    }
}
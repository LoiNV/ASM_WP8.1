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
            LoadGroup();            
        }
        
        public async Task<List<Items>> LoadItems(string groupName) {            

            var folder = await Package.Current.InstalledLocation.GetFolderAsync("Assets/Images/"+ groupName);
            var files = await folder.GetFilesAsync();
            return (files.Select(
                (f, i) => new Items()
                {
                    Name = f.Name,
                    ImagePath = f.Path,
                    MediaPath = f.Path.Replace(".jpg", ".wav")
                }).ToList());
        }

        public async void LoadGroup() {            
            this.Animals = new Groups("Animals") { Item = await LoadItems("Animals") };
            this.Cartoons = new Groups("Cartoons") { Item = await LoadItems("Cartoons") };
            this.Taunts = new Groups("Taunts") { Item = await LoadItems("Taunts") };
            this.Warnings = new Groups("Warnings") { Item = await LoadItems("Warnings") };
        }
        
    }
}
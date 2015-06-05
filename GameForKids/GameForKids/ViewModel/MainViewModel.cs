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
        private static string FOLDER = "store";
        private static string FILENAME = "data.txt";
        public ObservableCollection<Groups> Group { get; set; }

        public Groups Animals { get; set; }
        public Groups Cartoons { get; set; }
        public Groups Taunts { get; set; }
        public Groups Warnings { get; set; }

        public MainViewModel() {
            this.Group = new ObservableCollection<Groups>();

            //Animals
            ObservableCollection<Items> listItem1 = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="/Assets/Images/Animals/CatKitten.jpg", MediaPath= "/Assets/Audio/Animals/CatKitten.wav"},
                new Items(){Name="CatMeow", ImagePath="/Assets/Images/Animals/CatMeow.jpg", MediaPath= "/Assets/Audio/Animals/CatMeow.wav"},
                new Items(){Name="Chimpanzee", ImagePath="/Assets/Images/Animals/Chimpanzee.jpg", MediaPath= "/Assets/Audio/Animals/Chimpanzee.wav"},
                new Items(){Name="Cow", ImagePath="/Assets/Images/Animals/Cow.jpg", MediaPath= "/Assets/Audio/Animals/Cow.wav"}
            };
            this.Animals = new Groups("Animals") { Item = listItem1 };
            this.Group.Add(this.Animals);

            //Cartoons
            ObservableCollection<Items> listItem2 = new ObservableCollection<Items>(){
                new Items(){Name="CatKitten", ImagePath="/Assets/Images/Cartoons/Boing.jpg", MediaPath= "/Assets/Audio/Cartoons/Boing.wav"},
                new Items(){Name="CatMeow", ImagePath="/Assets/Images/Cartoons/Splat.jpg", MediaPath= "/Assets/Audio/Cartoons/Splat.wav"},
                new Items(){Name="Chimpanzee", ImagePath="/Assets/Images/Cartoons/Buglecharge.jpg", MediaPath= "/Assets/Audio/Cartoons/Buglecharge.wav"},
                new Items(){Name="Cow", ImagePath="/Assets/Images/Cartoons/Laser.jpg", MediaPath= "/Assets/Audio/Cartoons/Laser.wav"}
            };
            this.Cartoons = new Groups("Cartoons") {Item= listItem2 };
            this.Group.Add(this.Cartoons);
            
        }

        public async void SaveToJson() {
            var devices = Windows.Storage.KnownFolders.RemovableDevices;

            var sdCards = await devices.GetFoldersAsync();

            if (sdCards.Count == 0) return;

            var firstCard = sdCards[0];

            StorageFolder notesFolder = await firstCard.CreateFolderAsync(FOLDER, CreationCollisionOption.OpenIfExists);

            Stream stream = await notesFolder.OpenStreamForWriteAsync(FILENAME, CreationCollisionOption.ReplaceExisting);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ObservableCollection<Groups>));

            serializer.WriteObject(stream, this.Group);

            await stream.FlushAsync();

            stream.Dispose();
        }

        public async Task<ObservableCollection<Groups>> readCustomersFromSDCard()
        {
            var devices = Windows.Storage.KnownFolders.RemovableDevices;

            var sdCards = await devices.GetFoldersAsync();

            if (sdCards.Count == 0) return null;

            var firstCard = sdCards[0];

            StorageFolder notesFolder = await firstCard.GetFolderAsync(FOLDER);

            Stream stream = await notesFolder.OpenStreamForReadAsync(FILENAME);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Groups));

            ObservableCollection<Groups> result = serializer.ReadObject(stream) as ObservableCollection<Groups>;

            stream.Dispose();

            return result;
        }
    }
}

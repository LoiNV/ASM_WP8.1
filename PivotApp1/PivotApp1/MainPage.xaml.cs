using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PivotApp1.Resources;
using PivotApp1.ViewModels;
using PivotApp1.Model;
using System.Windows.Media;

namespace PivotApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            MainViewModel mvm = new MainViewModel();
            DataContext = mvm;
            CreateIconicTile();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void CreateIconicTile()
        {
            ShellTile tileId = FindTile("CreateIconicTile");
            if (tileId == null)
            {
                FlipTileData flipTile = new FlipTileData
                {
                    Title = "Cat Meow",
                    BackTitle = "ChimPanzee",
                    WideBackContent = "Một trò chơi vui vẻ và bổ ích cho trẻ em",
                    SmallBackgroundImage = new Uri("Assets/Images/Animals/CatMeow.jpg", UriKind.RelativeOrAbsolute),
                    BackgroundImage = new Uri("Assets/Images/Animals/CatMeow.jpg", UriKind.RelativeOrAbsolute),
                    BackBackgroundImage = new Uri("Assets/Images/Animals/ChimPanzee.jpg", UriKind.RelativeOrAbsolute),
                    WideBackgroundImage = new Uri("Assets/Images/Animals/CatMeow.jpg", UriKind.RelativeOrAbsolute),
                    WideBackBackgroundImage = new Uri("Assets/Images/Animals/ChimPanzee.jpg", UriKind.RelativeOrAbsolute)
                };
                ShellTile.Create(new Uri("/MainPage.xaml?newflipTile", UriKind.RelativeOrAbsolute), flipTile, true);
            }
            
        }

        private void UpdateIconicTile(Items item)
        {

            ShellTile tileId = FindTile("CreateIconicTile");
            if (tileId != null)
            {
                FlipTileData flipTile = new FlipTileData
                {
                    Title = item.Name,
                    SmallBackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    BackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    WideBackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute)
                };
                tileId.Update(flipTile);                
            }
            else
            {
                CreateIconicTile();
            }
        }
        private ShellTile FindTile(String uriArg)
        {
            try
            {
                ShellTile tileId = ShellTile.ActiveTiles.Single(t =>
                {
                    if (t.NavigationUri.ToString().EndsWith(uriArg))
                    {
                        return true;
                    }
                    return false;
                });
                return tileId;
            }
            catch
            {
                return null;
            }
        }

        private void listAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAnimals.SelectedItem != null)
            {
                Items item = listAnimals.SelectedItem as Items;
                media.Source = new Uri(item.MediaPath, UriKind.RelativeOrAbsolute);
                media.Play();
                UpdateIconicTile(item);
            }
        }

        private void listCartoons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCartoons.SelectedItem != null)
            {
                Items item = listCartoons.SelectedItem as Items;
                media.Source = new Uri(item.MediaPath, UriKind.RelativeOrAbsolute);
                media.Play();
                UpdateIconicTile(item);
            }
        }

        private void listTaunts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listTaunts.SelectedItem != null)
            {
                Items item = listTaunts.SelectedItem as Items;
                media.Source = new Uri(item.MediaPath, UriKind.RelativeOrAbsolute);
                media.Play();
                UpdateIconicTile(item);
            }
        }

        private void listWarnings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listWarnings.SelectedItem != null)
            {
                Items item = listWarnings.SelectedItem as Items;
                media.Source = new Uri(item.MediaPath, UriKind.RelativeOrAbsolute);
                media.Play();
                UpdateIconicTile(item);
            }
        }
    }
}
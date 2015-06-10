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

            MainViewModel mvm = new MainViewModel();
            DataContext = mvm;            
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void UpdateIconicTile(Items item)
        {
            ShellTile tileId = ShellTile.ActiveTiles.First();
            if (tileId != null)
            {
                FlipTileData flipTile = new FlipTileData
                {
                    Title = item.Name,
                    BackTitle = "Game For Kids",
                    SmallBackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    BackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    BackBackgroundImage = new Uri("Assets/Tiles/FlipCycleTileMedium.png", UriKind.Relative),
                    WideBackgroundImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    WideBackBackgroundImage = new Uri("Assets/Tiles/FlipCycleTileLarge.png", UriKind.Relative),
                };
                tileId.Update(flipTile);
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
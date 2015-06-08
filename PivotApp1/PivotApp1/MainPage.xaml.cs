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

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void UpdateIconicTile(Items item)
        {

            ShellTile tileId = FindTile("CreateIconicTile");
            if (tileId != null)
            {
                IconicTileData iconicTileData = new IconicTileData
                {
                    Title = item.Name,
                    IconImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    SmallIconImage = new Uri(item.ImagePath, UriKind.RelativeOrAbsolute),
                    Count = DateTime.Now.Second
                };
                tileId.Update(iconicTileData);
                MessageBox.Show("Iconic Tile đã được cập nhật");
            }
            else
            {
                MessageBox.Show("Hãy tạo Tile trước");
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
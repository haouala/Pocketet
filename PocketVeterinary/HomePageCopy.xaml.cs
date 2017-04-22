using PocketVeterinary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PocketVeterinary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePageCopy : Page
    {
        public Element c1 = new Element();
        public List<Publication> Publications;
        public HomePageCopy()
        {
            this.InitializeComponent();
            Publications = PublicationManager.getListPublication();
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListBoxItem.IsSelected)
            { Frame.Navigate(typeof(HomePageCopy)); }
            else if (VetsListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(VetsPage));
            }
            else if (ServicesListBoxItem.IsSelected)
            { Frame.Navigate(typeof(ServicesPage)); }
            else if (GuideListBoxItem.IsSelected)
            { Frame.Navigate(typeof(GuidePage)); }
        }

        private void foriteBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FavoritePage));
            //Frame.Navigate(typeof(FavoritePage));
        }

        private void profileBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ProfilePage));
        }

        private void aboutBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AboutPage));
        }

        /***********************************/
      
        private async void addFav(object sender, RoutedEventArgs e)
        {
           
            c1.name = Publications[PublicationList.SelectedIndex].name;
            c1.description = Publications[PublicationList.SelectedIndex].description;
          //  Debug.WriteLine("Selecteddqte" + PublicationList.SelectedIndex);
            List<Element> lstFav = new List<Element>();
            if (IsolatedStorageHelper.IsolatedStorageHelper.GetObject<List<Element>>("lstFav") != null)
            {
                lstFav = IsolatedStorageHelper.IsolatedStorageHelper.GetObject<List<Element>>("lstFav");
            }
            bool alreadyExists = lstFav.Any(x => x.name == c1.name);
            if (alreadyExists == false)
            {
                lstFav.Add(new Element() { name = c1.name, description = c1.description });
                IsolatedStorageHelper.IsolatedStorageHelper.SaveObject("lstFav", lstFav);
                var dialog = new MessageDialog("Item successfully added");
                await dialog.ShowAsync();
            }
            else
            {

                var dialog = new MessageDialog("Item already added!");
                await dialog.ShowAsync();

            }

        }
    }
}

using PocketVeterinary.Models;
using PocketVeterinary.UserControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            this.InitializeComponent();
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


        /********************/
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string url = "https://api.foursquare.com/v2/venues/explore/?venuePhotos=1&client_id=55F1QOARTVJYTKAT11J45VL4STLBGBPIAUMRUCXAP4MOZR0E&client_secret=KK5GFPLDSOSJINDLCK0DCYN5NSQD2E4G0HXQH2FCTW21RMY0&v=20160317&categoryId=5032897c91d4c4b30a586d69&ll={0},{1}";
            Geolocator locator = new Geolocator();
            Geoposition position = await locator.GetGeopositionAsync();

            url = string.Format(url, position.Coordinate.Point.Position.Latitude, position.Coordinate.Point.Position.Longitude);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var stream = await client.GetStreamAsync(url);
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));
                    RootObject response = (RootObject)serializer.ReadObject(stream);

                    gridVenues.Items.Clear();
                    if (response.response.groups != null)
                    {
                        foreach (var j in response.response.groups[0].items)
                        {
                            ServiceControl venueControl = new ServiceControl();
                            venueControl.Venue = j.venue;
                            gridVenues.Items.Add(venueControl);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
            }


        }
    }
}

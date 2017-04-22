using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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
    public sealed partial class ProfilePage : Page
    {
        public ProfilePage()
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

        private async void validate_Click(object sender, RoutedEventArgs e)
        {
            String url = "http://localhost/PocketVetWindows/insertElement.php";
            var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("name",ElementName.Text),
                new KeyValuePair<string, string>("description",ElementDescription.Text),


            };


            HttpClient client = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = await client.PostAsync(url, new FormUrlEncodedContent(values));

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(response.StatusCode.ToString());
                    var dialog = new MessageDialog("added succesfully ");
                    await dialog.ShowAsync();
                }
                else
                {
                    // problems handling here
                    string msg = response.IsSuccessStatusCode.ToString();

                    throw new Exception(msg);
                }
            }
            catch (Exception exc)
            {
                // .. and understanding the error here
                Debug.WriteLine(exc.ToString());
            }
        }
    }
}

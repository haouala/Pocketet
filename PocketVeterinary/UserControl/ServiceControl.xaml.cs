using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PocketVeterinary.UserControl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ServiceControl : Page
    {
        public ServiceControl()
        {
            this.InitializeComponent();
        }
        private Models.Venue venue;
        public Models.Venue Venue
        {
            get { return venue; }
            set
            {
                venue = value;

                if (venue.name != null)
                    name.Text = venue.name;
                if (venue.contact.phone != null)
                    contact.Text = venue.contact.phone;
                if (venue.location.address != null)
                    location.Text = venue.location.address;
                if (venue.featuredPhotos != null)
                    img.Source = new BitmapImage(new Uri(venue.featuredPhotos.items[0].prefix + "width" + venue.featuredPhotos.items[0].width + venue.featuredPhotos.items[0].suffix));
                //  img.Source = new BitmapImage(new Uri(venue.photos.groups[0].items[0].prefix + "width" + venue.photos.groups[0].items[0].width + venue.photos.groups[0].items[0].suffix));

                /* if (venue.featuredPhotos != null)
                     prefix.Text = venue.featuredPhotos.items[0].prefix;
                     */

            }
        }
    }
}

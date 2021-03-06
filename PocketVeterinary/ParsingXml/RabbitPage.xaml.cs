﻿using System;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PocketVeterinary.ParsingXml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RabbitPage : Page
    {
        private helperXml model;
        public RabbitPage()
        {
            this.InitializeComponent();
            model = new helperXml();
            this.DataContext = model;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!model.Isloaded)
            {
                model.LoadRss("http://193.95.2.149/veterinary/rabbit");
            }

        }
        /****************************/
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
        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GuidePage));
        }
        /********************************/
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
        /********************************/
    }
}


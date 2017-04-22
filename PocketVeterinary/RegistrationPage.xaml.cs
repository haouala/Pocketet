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
    public sealed partial class RegistrationPage : Page
    {
        bool loggedIn = false; 

        public RegistrationPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {

             String url = "http://localhost/PocketVetWindows/insert.php";
               var values = new List<KeyValuePair<String, String>>
               {
                   new KeyValuePair<string, string>("name",name.Text),
                   new KeyValuePair<string, string>("username",username.Text),
                   new KeyValuePair<string, string>("password",password.Text)

               };

               // third solution 
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
                    loggedIn = true;
                    Frame.Navigate(typeof(HomePageCopy));
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


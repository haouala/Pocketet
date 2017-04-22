using PocketVeterinary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PocketVeterinary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           // Frame.Navigate(typeof(HomePage));
            //HomeListBoxItem.IsSelected = true; 
        }



        private async void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {

            /*
                        UserPhp user = new UserPhp();

                        user = UserPhp.UserPhpManagers.getUsername(username.Text.ToString()).Result;
                        if (user == null)

                            Debug.WriteLine("nulll user");

                        if (user.username.Equals(username.Text) & user.password.Equals(password.Password))
                        {
                            user.logged = true;
                            Debug.WriteLine("logged in = " + user.logged);

                            Frame.Navigate(typeof(HomePageCopy));

                       }
                       */
            //////////////////Second method haifa /////////////////////
           
            try
            {
                using (HttpClient client1 = new HttpClient())
                {
                    //String url2 = "http://localhost/PocketVetWindows/loginHaifa.php=" + username.Text + "&password=" + password.Password;
                    String url2 = "http://localhost/PocketVetWindows/loginHaifa.php?username=" + username.Text + "&password=" + password.Text;

                    Debug.WriteLine(url2);
                    var stram = await client1.GetStreamAsync(url2);
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootUser));
                    RootUser response = (RootUser)serializer.ReadObject(stram);


                    Debug.WriteLine(response.user);

                    if (response !=null)
                    {
                        var dialog = new MessageDialog("verify ");
                        await dialog.ShowAsync();

                       
                    }
                    else
                    {
                       

                        var dialog = new MessageDialog("failed exception");
                        await dialog.ShowAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                Frame.Navigate(typeof(HomePageCopy));
            }
        }


        /* private async void submit_login(object sender, RoutedEventArgs e)
        {
            String log = login.Text;
            String mdp = mot_de_pass.Password;



            try
            {
                using (HttpClient client1 = new HttpClient())
                {
                    String url2 = "http://d5b7a37e.ngrok.io/OBPV/logIn.php?login=" + log+"&password="+mdp;
                    Debug.WriteLine(url2);
                    var stram = await client1.GetStreamAsync(url2);
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootUserAppObject));
                    RootUserAppObject response = (RootUserAppObject)serializer.ReadObject(stram);
    
                    if (response != null)
                    {
                        this.current_user = response.user[0];
                     
                        btn1.Visibility = Visibility.Collapsed;
                        btn2.Visibility = Visibility.Collapsed;
                        btn3.Visibility = Visibility.Collapsed;


                        bar.Visibility = Visibility.Visible;
                        commentaires.Visibility = Visibility.Visible;

                        formulaire.Visibility = Visibility.Collapsed;
                        confirm.Visibility = Visibility.Collapsed;

                        formulaire_login.Visibility = Visibility.Collapsed;
                        confirm_login.Visibility = Visibility.Collapsed;

                        info_user.Visibility = Visibility.Visible;
                        info_user.Visibility = Visibility.Visible;
                        info_user_name.Text = current_user.firstName + " " + current_user.secondName;
                        info_user_mail.Text = current_user.email;

                    }
                    else
                    {

                        var messageDialog = new MessageDialog("failed to connect to your account ");
                        messageDialog.Commands.Add(new UICommand("Ok", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                        messageDialog.DefaultCommandIndex = 0;
                        messageDialog.CancelCommandIndex = 1;
                        await messageDialog.ShowAsync();
                    }
                }
            }
            catch (Exception ex) {

                var messageDialog = new MessageDialog("failed to connect to your account "+ex.ToString());
                messageDialog.Commands.Add(new UICommand("Ok", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                await messageDialog.ShowAsync();
            }
        } */
        private void BtnRegisterMainPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistrationPage));
        }
    }

  
}


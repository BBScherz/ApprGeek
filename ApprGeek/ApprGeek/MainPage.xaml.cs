using ApprGeek.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApprGeek
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<App, string>(App.Current, "Photo", (snd, arg) =>
            {
                Pfp.Source = arg + ".jpg";
            });

            MessagingCenter.Subscribe<App, string>(App.Current, "Name", (snd,arg) =>
            {
                namelabel.Text = arg;
            });

            MessagingCenter.Subscribe<App, string>(App.Current, "Phone", (snd, arg) =>
            {
                phonelabel.Text = arg;
            });

            MessagingCenter.Subscribe<App, string>(App.Current, "Email", (snd, arg) =>
            {
                emaillabel.Text = arg;
            });

            MessagingCenter.Subscribe<App, string>(App.Current, "Bio", (snd, arg) =>
            {
                aboutlabel.Text = arg;
            });

            Pfp.Clicked += (s, e) => Navigation.PushAsync(new PhotoPage());
            name.Clicked += (s, e) => Navigation.PushAsync(new NamePage());
            phone.Clicked += (s, e) => Navigation.PushAsync(new PhonePage());
            email.Clicked += (s, e) => Navigation.PushAsync(new EmailPage());
            about.Clicked += (s, e) => Navigation.PushAsync(new AboutPage());
        }
    }
}

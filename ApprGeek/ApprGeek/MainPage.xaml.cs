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

            name.Clicked += (s, e) => Navigation.PushAsync(new NamePage());
            phone.Clicked += (s, e) => Navigation.PushAsync(new PhonePage());
            email.Clicked += (s, e) => Navigation.PushAsync(new EmailPage());
            about.Clicked += (s, e) => Navigation.PushAsync(new AboutPage());
        }
    }
}

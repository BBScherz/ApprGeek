using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApprGeek.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();

        }

        async void UpdateAboutClicked(object sender, EventArgs e)
        {
            string bio = Abt.Text;

            MessagingCenter.Send<App, string>(App.Current as App, "Bio", bio);

            await Navigation.PopAsync();
        }

    }
}
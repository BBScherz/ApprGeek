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
	public partial class EmailPage : ContentPage
	{
		public EmailPage ()
		{
			InitializeComponent ();

			Eml.Keyboard = Keyboard.Email;
        }

        async void UpdateEmailClicked(object sender, EventArgs e)
        {
            string email = Eml.Text;

            MessagingCenter.Send<App, string>(App.Current as App, "Email", email);

            await Navigation.PopAsync();
        }
    }
}
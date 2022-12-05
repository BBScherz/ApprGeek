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
	public partial class PhonePage : ContentPage
	{
		public PhonePage ()
		{
			InitializeComponent ();

			Pnum.Keyboard = Keyboard.Telephone;
        }

        async void UpdatePhoneClicked(object sender, EventArgs e)
        {
            string num = Pnum.Text;
            string formatted = "(" + num.Substring(0,3) + ")" + num.Substring(3,3) + "-" + num.Substring(6);
            
            MessagingCenter.Send<App, string>(App.Current as App, "Phone", formatted);

            await Navigation.PopAsync();
        }
    }
}
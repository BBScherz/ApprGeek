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
	public partial class PhotoPage : ContentPage
	{
		public PhotoPage ()
		{
			InitializeComponent ();
		}

        async void UpdatePhotoClicked(object sender, EventArgs e)
        {
            string selected = (string)photopicker.SelectedItem;

            MessagingCenter.Send<App, string>(App.Current as App, "Photo", selected);

            await Navigation.PopAsync();
        }
    }
}
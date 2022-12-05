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
	public partial class NamePage : ContentPage
	{
		public NamePage ()
		{
			InitializeComponent ();
		}

		async void UpdateNameClicked (object sender, EventArgs e)
		{

			string msg = Fname.Text + " " + Lname.Text;
			MessagingCenter.Send<App, string>(App.Current as App, "Name", msg);
			
			await Navigation.PopAsync();
		}
	}
}
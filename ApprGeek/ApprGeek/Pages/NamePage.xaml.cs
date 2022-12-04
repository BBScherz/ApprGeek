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

		async void OnUpdateClicked (object sender, EventArgs e)
		{
			var fullname = Fname.Text + Lname.Text;
			
			
			await Navigation.PopAsync();
		}
	}
}
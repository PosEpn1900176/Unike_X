using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unike.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
		public HomeView ()
		{
			InitializeComponent ();
		}

        private void btnAccess(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginView());
        }

        private void btnCreate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroContatoView());
        }
    }
}
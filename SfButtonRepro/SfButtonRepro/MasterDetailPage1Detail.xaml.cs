using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfButtonRepro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailPage1Detail : ContentPage
	{
		public MasterDetailPage1Detail()
		{
			InitializeComponent();
		}

		private void SfButton_OnClicked(object sender, EventArgs e)
		{
			Application.Current.MainPage = Static.PreviousPage;
		}
	}
}
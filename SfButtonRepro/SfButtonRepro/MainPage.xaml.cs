using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfButtonRepro
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void SfButton_OnClicked(object sender, EventArgs e)
		{
			Static.PreviousPage = Application.Current.MainPage;
			Application.Current.MainPage = new MasterDetailPage1();
		}
	}
}

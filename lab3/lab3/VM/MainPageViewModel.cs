using System;

using Xamarin.Forms;

namespace lab3.VM
{
	public class MainPageViewModel : ContentPage
	{
		public MainPageViewModel ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}



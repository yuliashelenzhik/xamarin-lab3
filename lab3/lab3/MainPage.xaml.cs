using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3.Views;
using lab3.VM;
using Xamarin.Forms;

namespace lab3
{
    public partial class MainPage : ContentPage, IFlightPage
    {

        public FlightViewModel ViewModel { get; set; }
        public static object Flights { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new FlightViewModel();
            BindingContext = ViewModel;
        }

        //private string test = "Test";

        private void Btn_Clicked(object sender, EventArgs e)
        {

            string destination = DestinationEntry.Text.Trim();

            if (!string.IsNullOrEmpty(destination))
            {
                var flights = ViewModel.GetFlightsForDestination(destination);
                FlightListView.ItemsSource = flights;
                //DisplayAlert("1", flights.ToString(), "Ok");
            }

            
            //LabelTest.Text = test;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.LoadData();
        }
    }

}


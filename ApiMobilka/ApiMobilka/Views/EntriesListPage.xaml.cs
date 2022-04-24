using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiMobilka.Models;
using ApiMobilka.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiMobilka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntriesListPage : ContentPage
    {
        public EntriesListPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LVDeds.ItemsSource = await App.RequestManager.GetEntrieModels();
        }

        private void LVDeds_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EntryPage(LVDeds.SelectedItem as EntryModel));
        }
    }
}
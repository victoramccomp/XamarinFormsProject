using System;
using XamarinFormsProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsProject.Views
{
    public partial class DetailsPage : ContentPage
    {
        Models.Cat SelectedCat;

        public DetailsPage(Cat selectedCat)
        {
            InitializeComponent();
            this.SelectedCat = selectedCat;
            BindingContext = this.SelectedCat;

            ButtonWebSite.Clicked += ButtonWebSite_Clicked;
        }

        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedCat.WebSite.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedCat.WebSite));
            }
        }
    }
}

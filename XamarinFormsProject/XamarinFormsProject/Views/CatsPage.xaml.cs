using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
            ListViewCats.ItemSelected += ListViewCats_ItemSelected;
        }

        private async void ListViewCats_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedCat = e.SelectedItem as Models.Cat;
            if (SelectedCat != null)
            {
                await Navigation.PushAsync(new DetailsPage(SelectedCat));
                ListViewCats.SelectedItem = null;
            }
        }
    }
}

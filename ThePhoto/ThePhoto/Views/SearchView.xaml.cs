using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("CollectionId", "CollectionId")]
    public partial class SearchView : ContentPage
    {
        private SearchViewModel vm;
        private string collectionId;

        public string CollectionId
        {
            get => collectionId; set
            {
                collectionId = value;
                vm = new SearchViewModel(CollectionId);
                BindingContext = vm;
            }
        }

        public SearchView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            searchBox.Focus();
        }
    }
}
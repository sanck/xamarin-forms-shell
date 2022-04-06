using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeaturedDetailView : ContentPage
    {
        private FeaturedDetailViewModel vm =
            new FeaturedDetailViewModel();

        public FeaturedDetailView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
using System.Windows.Input;
using ThePhoto.Views;
using Xamarin.Forms;
using System;

namespace ThePhoto
{
    public partial class App : Application
    {

        public ICommand HelpCommand => new Command(() =>
        {
            Device.OpenUri(new Uri("https://google.com"));
        });

        public ICommand LuckyCommand => new Command(async () =>
        {
            //await Shell.Current.GoToAsync("//cancun");
            //await Shell.Current.GoToAsync("featureView");
            //await Shell.Current.GoToAsync("//chicken/featuredView");
            //await Shell.Current.Navigation.PushModalAsync(new FeaturedView());
        });

        //https://unsplash.com/oauth/applications/316883 
        public const string ServiceId = "-4hGT7JEq3Rn5itemQbrv0wyOhXgKIJwyDsPWFABqUo";
        public App()
        {
            InitializeComponent();

            RegisterRoutes();

            //MainPage = new RandomPhotoView();
            MainPage = new AppShell();
            //MainPage = new AppShellTabs();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            //Routing.RegisterRoute("//chicken/featuredView", typeof(FeaturedView));
            Routing.RegisterRoute("featureDetail", typeof(FeaturedDetailView));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

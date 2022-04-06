using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ThePhoto.Models;
using Unsplasharp;
using Xamarin.Forms;

namespace ThePhoto.ViewModels
{
   
    public class FeaturedDetailViewModel
    {
        private string collectionId = "4807737";

        public ObservableCollection<Photo> PhotosList { get; set; } =
            new ObservableCollection<Photo>();
        public FeaturedDetailViewModel()
        {
            Task.Run(async () =>
            {
                await GetPhotos();
            });
        }

        public async Task GetPhotos()
        {
            PhotosList.Clear();
            var client = new UnsplasharpClient(App.ServiceId);
            var photosList = await client.GetCollectionPhotos(collectionId);
            foreach (var photo in photosList)
            {
                var newPhoto = new Photo
                {
                    Url = photo.Urls.Regular,
                    Likes = photo.Likes
                };
                PhotosList.Add(newPhoto);
            }
        }
    }
}

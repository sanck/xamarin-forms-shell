using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePhoto.Models;
using Xamarin.Forms;

namespace ThePhoto.Search
{
    public class PhotoSearchHandler : SearchHandler
    {
        public List<CollectionModel> Suggestions { get; set; } =
            new List<CollectionModel>();

        public PhotoSearchHandler()
        {
            var helper = new SearchHelper();
            Task.Run(async () =>
            {
                Suggestions = await helper.GetSearchData();
                ItemsSource = Suggestions;
            });
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Suggestions
                    .Where(s => s.Title
                        .ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Shell.Current.GoToAsync($"//searchPage?CollectionId={((CollectionModel)item).CollectionId}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElectricalSymbols
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SymList.ItemsSource = GetElements();
        }

        IEnumerable<ElementGroup> GetElements(string searchText = null)
        {
            var elements = ElementsService.GetElementGroupList();

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return elements;
            }

            return elements.Where(c => c.Family.Contains(searchText.ToUpper()));
        }

        private async void SymList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var element = e.SelectedItem as Element;
            await Navigation.PushAsync(new ElementDetailPage(element));

            SymList.SelectedItem = null;
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            SymList.ItemsSource = GetElements(e.NewTextValue);
        }
    }
}

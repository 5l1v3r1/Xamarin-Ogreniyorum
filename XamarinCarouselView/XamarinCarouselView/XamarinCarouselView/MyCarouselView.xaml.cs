using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinCarouselView
{
    public partial class MyCarouselView : ContentPage
    {
        List<ViewObject> Items = new List<ViewObject>();
        public MyCarouselView()
        {
            InitializeComponent();
            GenerateSampleData();
            myCV.ItemsSource = Items;
            myCV.ItemSelected += MyCV_ItemSelected;
        }

        private void MyCV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewObject selected = (ViewObject)e.SelectedItem;
            DisplayAlert("Xamarin CarouselView", selected.Uri, "OK");
        }

        private string GetRandomImageUrl(int width, int height)
        {
            return string.Format("http://loremflickr.com/{1}/{2}/cat?filename={0}.jpg",
                Guid.NewGuid().ToString("N"), width, height);
        }

        private void GenerateSampleData()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new ViewObject { Uri = GetRandomImageUrl(300, 300) });
            }
        }

        class ViewObject
        {
            public string Uri { get; set; }
        }
    }
}
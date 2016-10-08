using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace XamarinReader
{
    public class GeneratePage : ContentPage
    {
        public GeneratePage()
        {
            ZXingBarcodeImageView barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView"
            };

            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeValue = "http://www.xamarintr.com";

            Content = barcode;
        }
    }
}
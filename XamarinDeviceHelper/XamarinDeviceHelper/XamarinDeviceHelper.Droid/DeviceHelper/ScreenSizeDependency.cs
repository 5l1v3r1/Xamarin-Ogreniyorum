using Android.Content.Res;
using XamarinDeviceHelper.Droid.DeviceHelper;
using XamarinDeviceHelper.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(ScreenSizeDependency))]
namespace XamarinDeviceHelper.Droid.DeviceHelper
{
    public class ScreenSizeDependency : IDeviceHelper
    {
        public Helper.DeviceHelper GetDevice()
        {
            var metrics = Resources.System.DisplayMetrics;
            Helper.DeviceHelper _helper = new Helper.DeviceHelper
            {
                ScreenHeight = ConvertPixelsToDp(metrics.HeightPixels),
                ScreenWidth = ConvertPixelsToDp(metrics.WidthPixels)
            };
            return _helper;
        }
        private int ConvertPixelsToDp(int pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.System.DisplayMetrics.Density);
            return dp;
        }
    }
}
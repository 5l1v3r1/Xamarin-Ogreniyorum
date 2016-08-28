using UIKit;
using Xamarin.Forms;
using XamarinDeviceHelper.Helper;
using XamarinDeviceHelper.iOS.DeviceHelper;

[assembly: Dependency(typeof(ScreenSizeDependency))]
namespace XamarinDeviceHelper.iOS.DeviceHelper
{
    public class ScreenSizeDependency : IDeviceHelper
    {
        public Helper.DeviceHelper GetDevice()
        {
            Helper.DeviceHelper _helper = new Helper.DeviceHelper
            {
                ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height,
                ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width
            };
            return _helper;
        }
    }
}

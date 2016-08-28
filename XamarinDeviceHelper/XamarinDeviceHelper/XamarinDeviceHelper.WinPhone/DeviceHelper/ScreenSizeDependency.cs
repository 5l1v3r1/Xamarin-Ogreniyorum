using Windows.UI.Xaml;
using Xamarin.Forms;
using XamarinDeviceHelper.Helper;
using XamarinDeviceHelper.WinPhone.DeviceHelper;

[assembly: Dependency(typeof(ScreenSizeDependency))]
namespace XamarinDeviceHelper.WinPhone.DeviceHelper
{
    public class ScreenSizeDependency : IDeviceHelper
    {
        public Helper.DeviceHelper GetDevice()
        {
            Helper.DeviceHelper _helper = new Helper.DeviceHelper
            {
                ScreenHeight = (int)Window.Current.Bounds.Height,
                ScreenWidth = (int)Window.Current.Bounds.Width
            };
            return _helper;
        }
    }
}

using PCL_Ornek.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PCL_Ornek.Views
{
    public partial class MainPage : ContentPage
    {
        List<PickerModel> _pickerModel;
        public MainPage()
        {
            InitializeComponent();
            _pickerModel = PickerModel.CreateModel();
            foreach (var item in _pickerModel)
                picker1.Items.Add(item.Name);
            picker1.Title = "Colors";
            picker1.SelectedIndex = 0;
            picker1.SelectedIndexChanged += Picker1_SelectedIndexChanged;

            stepper1.ValueChanged += Stepper1_ValueChanged;

            switcher1.Toggled += Switcher1_Toggled;

            slider1.ValueChanged += Slider1_ValueChanged;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSlider.Text = e.NewValue.ToString();
        }

        private void Switcher1_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switcher", "Value : " + e.Value, "Ok");
        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblStepper.Text = e.NewValue.ToString();
            var progressValue = e.NewValue / 10;
            progress1.ProgressTo(progressValue, 250, Easing.BounceIn);
        }

        private void Picker1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedColor = picker1.Items[picker1.SelectedIndex];
            Color _color = _pickerModel.Find(x => x.Name == selectedColor).Color;
            lblColor.Text = "Selected Color : " + selectedColor;
            lblColor.TextColor = _pickerModel.Find(x => x.Name == selectedColor).Color;
            boxview1.BackgroundColor = _color;
            DisplayAlert("Colors", lblColor.Text, "Ok");
        }

        private void btnClick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            DisplayAlert("Event", "Button Clicked " + btn.Text, "Ok");
        }
    }
}

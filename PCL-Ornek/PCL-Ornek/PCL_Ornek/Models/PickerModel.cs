using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PCL_Ornek.Models
{
    public class PickerModel
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public static List<PickerModel> CreateModel()
        {
            List<PickerModel> _model = new List<PickerModel>()
            {
                new PickerModel() { Name = "Aqua", Color = Color.Aqua },
                new PickerModel() { Name = "Blue", Color = Color.Blue },
                new PickerModel() { Name = "Gray", Color = Color.Gray },
                new PickerModel() { Name = "Lime", Color = Color.Lime },
                new PickerModel() { Name = "Navy", Color = Color.Navy },
                new PickerModel() { Name = "Purple", Color = Color.Purple },
                new PickerModel() { Name = "Silver", Color = Color.Silver },
                new PickerModel() { Name = "White", Color = Color.White },
                new PickerModel() { Name = "Black", Color = Color.Black },
                new PickerModel() { Name = "Fuchsia", Color = Color.Fuchsia },
                new PickerModel() { Name = "Green", Color = Color.Green },
                new PickerModel() { Name = "Maroon", Color = Color.Maroon },
                new PickerModel() { Name = "Olive", Color = Color.Olive },
                new PickerModel() { Name = "Red", Color = Color.Red },
                new PickerModel() { Name = "Teal", Color = Color.Teal },
                new PickerModel() { Name = "Yellow", Color = Color.Yellow },
            };

            return _model;
        }
    }
}

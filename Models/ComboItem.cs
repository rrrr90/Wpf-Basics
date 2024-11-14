using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Wpf_Basics.Models
{
    class ComboItem
    {
        public string Value { get; set; } = default!;
        public Brush Brush { get; set; } = default!;

        public override string ToString()
        {
            return $"Value:{Value}, Brush{Brush}";
        }

        public static List<ComboItem> Items { get; set; } = new List<ComboItem>
        {
            new ComboItem { Value = "Red", Brush = Brushes.Red },
            new ComboItem { Value = "Green", Brush = Brushes.Green },
            new ComboItem { Value = "Blue", Brush = Brushes.Blue }
        };
    }
}

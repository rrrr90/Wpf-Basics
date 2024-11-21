using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Wpf_Basics.Utils
{
    public class TextBoxHelper
    {

        public static bool GetUseOnPropertyChanged(DependencyObject obj)
        {
            return (bool)obj.GetValue(UseOnPropertyChangedProperty);
        }

        public static void SetUseOnPropertyChanged(DependencyObject obj, bool value)
        {
            obj.SetValue(UseOnPropertyChangedProperty, value);
        }

        // Using a DependencyProperty as the backing store for UseOnPropertyChanged.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UseOnPropertyChangedProperty =
            DependencyProperty.RegisterAttached("UseOnPropertyChanged", typeof(bool), typeof(TextBoxHelper), new PropertyMetadata(false, OnUseOnPropertyChanged));

        private static void OnUseOnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox? textBox;
            if ((textBox = d as TextBox) == null) return;

            if ((bool)e.NewValue)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
            else
            {
                textBox.TextChanged -= TextBox_TextChanged;
            }
        }

        private static void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            BindingExpression? bindingExpression = textBox?.GetBindingExpression(TextBox.TextProperty);
            bindingExpression?.UpdateSource();
        }
    }
}

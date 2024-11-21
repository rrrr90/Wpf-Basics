using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf_Basics.Utils
{
    public class PasswordPropertyHelper
    {
        public static string GetBoundPassword(DependencyObject obj)
        {
            return (string)obj.GetValue(BoundPasswordProperty);
        }

        public static void SetBoundPassword(DependencyObject obj, string value)
        {
            obj.SetValue(BoundPasswordProperty, value);
        }

        // Using a DependencyProperty as the backing store for BoundPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BoundPasswordProperty =
            DependencyProperty.RegisterAttached("BoundPassword", typeof(string), typeof(PasswordPropertyHelper), new PropertyMetadata("<Default>", OnBoundPasswordChanged));

        private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox? passwordBox;
            if ((passwordBox = d as PasswordBox) is null) return;

            passwordBox.PasswordChanged -= PasswordChanged;
            passwordBox.PasswordChanged += PasswordChanged;
        }

        private static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox? passwordBox;
            if ((passwordBox = sender as PasswordBox) is null) return;

            SetBoundPassword(passwordBox, passwordBox.Password);
        }
    }
}

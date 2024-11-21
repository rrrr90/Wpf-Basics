using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Basics
{
    /// <summary>
    /// AttachedPropertyView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AttachedPropertyView : UserControl
    {
        public AttachedPropertyView()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.AttachedPropertyViewModel();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            BindingExpression? bindingExpression = textBox?.GetBindingExpression(TextBox.TextProperty);
            bindingExpression?.UpdateSource();
        }
    }
}

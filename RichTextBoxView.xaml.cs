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
    /// RichTextBoxView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RichTextBoxView : UserControl
    {
        public RichTextBoxView()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.RichTextBoxViewModel();

            TextRange range = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd);
            range.Text = "123";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Paragraph pargs = new Paragraph();
            Run run1 = new Run() { Text = "ABCD" };
            Run run2 = new Run() { Text = "1234", FontWeight= FontWeights.Bold };
            Run run3 = new Run() { Text = "!@#$" };
            pargs.Inlines.Add(run1);
            pargs.Inlines.Add(run2);
            pargs.Inlines.Add(run3);
            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(pargs);

            richTextBox1.Document = doc;
        }

        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            TogglePropertyValue(richTextBox1, TextElement.FontWeightProperty, FontWeights.Bold, FontWeights.Normal);
        }

        private void TogglePropertyValue(RichTextBox richtextbox, DependencyProperty property, object set, object unset)
        {
            TextRange range = richtextbox.Selection;
            if (range.IsEmpty) return;

            object cur = range.GetPropertyValue(property);
            if(cur.GetHashCode() == set.GetHashCode())
            {
                range.ApplyPropertyValue(property, unset);
            }
            else
            {
                range.ApplyPropertyValue(property, set);
            }
        }
    }
}

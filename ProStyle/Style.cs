using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading.Tasks;

namespace ProStyle
{ 
    public class CustomButton : Button
    {
        public CustomButton()
        {
            Background = new SolidColorBrush(Color.FromRgb(255, 128, 0));
            Foreground = Brushes.White;
            FontSize = 16;
            FontWeight = FontWeights.Bold;
            BorderThickness = new Thickness(2);
            BorderBrush = Brushes.White;
            Padding = new Thickness(10);
        }
    }

    public class CustomLabel : System.Windows.Controls.Label
    {
        public CustomLabel()
        {
            Foreground = Brushes.Green;
            FontSize = 18;
            FontWeight = FontWeights.Bold;
        }
    }

    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            Background = Brushes.White;
            Foreground = Brushes.Black;
            FontSize = 16;
            BorderThickness = new Thickness(1);
            BorderBrush = Brushes.Gray;
            Padding = new Thickness(5);
        }
    }

    public class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            Background = Brushes.White;
            Foreground = Brushes.Black;
            FontSize = 16;
            BorderThickness = new Thickness(2);
            BorderBrush = Brushes.Teal;
            Padding = new Thickness(5);
        }
    }

    public class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            Background = Brushes.White;
            Foreground = Brushes.Black;
            FontSize = 16;
            BorderThickness = new Thickness(2);
            BorderBrush = Brushes.Blue;
            Padding = new Thickness(5);
        }
    }
}

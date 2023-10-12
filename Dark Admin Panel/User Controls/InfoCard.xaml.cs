using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Dark_Admin_Panel.User_Controls
{
    /// <summary>
    /// Interaction logic for InfoCard.xaml
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); } 
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(InfoCard));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(InfoCard));

        public FontAwesome.Sharp.IconChar Icon
        {
            get { return (FontAwesome.Sharp.IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesome.Sharp.IconChar), typeof(InfoCard));

        public Color Background_01
        {
            get { return (Color)GetValue(Background_01Property); }
            set { SetValue(Background_01Property, value); }
        }
        public static readonly DependencyProperty Background_01Property = DependencyProperty.Register("Background_01", typeof(Color), typeof(InfoCard));
        public Color Background_02
        {
            get { return (Color)GetValue(Background_02Property); }
            set { SetValue(Background_02Property, value); }
        }
        public static readonly DependencyProperty Background_02Property = DependencyProperty.Register("Background_02", typeof(Color), typeof(InfoCard));
        public Color ElipseBackground_01
        {
            get { return (Color)GetValue(ElipseBackground_01Property); }
            set { SetValue(ElipseBackground_01Property, value); }
        }
        public static readonly DependencyProperty ElipseBackground_01Property = DependencyProperty.Register("ElipseBackground_01", typeof(Color), typeof(InfoCard));
        public Color ElipseBackground_02
        {
            get { return (Color)GetValue(ElipseBackground_02Property); }
            set { SetValue(ElipseBackground_02Property, value); }
        }
        public static readonly DependencyProperty ElipseBackground_02Property = DependencyProperty.Register("ElipseBackground_02", typeof(Color), typeof(InfoCard));
    }
}

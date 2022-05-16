using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using SliderRGB.Annotations;

namespace SliderRGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _redComponent;
        public double RedComponent
        {
            get
            {
                return _redComponent;
            }
            set
            {
                _redComponent = value;
                OnPropertyChanged();
            }
        }

        private double _greenComponent;
        public double GreenComponent
        {
            get
            {
                return _greenComponent;
            }
            set
            {
                _greenComponent = value;
                OnPropertyChanged();
            }
        }

        private double _blueComponent;
        public double BlueComponent
        {
            get
            {
                return _blueComponent;
            }
            set
            {
                _blueComponent = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            RedComponent = 255;
            GreenComponent = 0;
            BlueComponent = 0;
        }
    }
}

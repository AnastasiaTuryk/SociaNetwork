using SociaNetwork.SearchPeople;
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
using System.Windows.Shapes;

namespace SociaNetwork.HelperWindows
{
    /// <summary>
    /// Interaction logic for ListOfPersonsWindow.xaml
    /// </summary>
    public partial class ListOfPersonsWindow : Window
    {

        public ListOfPersonsWindow(List<string> lst)
        {
            InitializeComponent();
            if(lst != null && lst.Count > 0)
            {
                foreach(var el in lst)
                {
                    PeopelComboBox.Items.Add(el);
                }
            }

        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void OFF(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NameLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

     
        private void PeopelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PersonInfo info = new PersonInfo(PeopelComboBox.SelectedItem.ToString());
            info.Show();

        }
    }
}

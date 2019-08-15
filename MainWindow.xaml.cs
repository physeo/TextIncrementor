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

namespace TextIncrementor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnIncrement_Click(object sender, RoutedEventArgs e)
        {
            int initial;
            int increment;
            StringBuilder sb = new StringBuilder();
            try
            {
                if (int.TryParse(txtNumber.Text.Trim(), out initial) &&
                int.TryParse(txtAmount.Text.Trim(), out increment))
                {
                    for (int i = initial; i < initial + increment; i++)
                        sb.AppendLine(string.Format(txtText.Text, i)).AppendLine();
                }
                else if (txtList.LineCount > 0)
                {
                    var l = txtList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in l)
                        sb.AppendLine(string.Format(txtText.Text, s)).AppendLine();
                }

                txtText.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You broke it");
            }
        }
    }
}

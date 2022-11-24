using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab2_RPM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? NickName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NicknameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox NicknameTextBox = (TextBox)sender;
            NicknameTextBox.Text = string.Empty;
            NicknameTextBox.GotFocus -= NicknameTextBox_GotFocus;
            NicknameTextBox.Foreground = Brushes.Black;
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            NickName = NicknameTextBox.Text;
            GameWindow GW = new GameWindow(NickName);
            GW.Show();
            this.Hide();
        }
    }
}

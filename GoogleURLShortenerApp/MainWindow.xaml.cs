using System;
using System.Windows;

namespace GoogleURLShortenerDesktopGUI {
  public partial class MainWindow : Window {
    // Show the short URL in the window after the long URL has been converted
    private void Shorten_URL(object sender, RoutedEventArgs e) {
      shortURL.Text = URLShortener.ShortenURL(longURL.Text);
      copy.Visibility = System.Windows.Visibility.Visible;
      clear.Visibility = System.Windows.Visibility.Visible;
    }

    // Copies the short URL to the clipboard for easy of use
    private void Copy(object sender, RoutedEventArgs e) {
      Clipboard.SetText(shortURL.Text);
    }

    // Clears the short URL TextBox and buttons for a new URL to be shortened
    private void Clear(object sender, RoutedEventArgs e) {
      shortURL.Text = "";
      longURL.Text = "";
      copy.Visibility = System.Windows.Visibility.Hidden;
      clear.Visibility = System.Windows.Visibility.Hidden;
    }

    public MainWindow() {
      InitializeComponent();
    }
  }
}
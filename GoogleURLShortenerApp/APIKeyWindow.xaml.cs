using System.IO;
using System.Windows;

namespace GoogleURLShortenerApp {
  public partial class APIKeyWindow : Window {

    // Write the user's Google API key to a local file
    private void SubmitAPIKey(object sender, RoutedEventArgs e) {
      // Make sure the user provided input
      if (apiKey.Text.Length < 1) {
        MessageBox.Show("Please enter your Google API Key", "Error");
      }
      else {
        File.WriteAllText("apikey", apiKey.Text);

        // Double-check to make sure the file was written
        if (File.Exists("apikey")) {
          new MainWindow().Show();
          this.Close();
        }
        else {
          MessageBox.Show("There was a problem saving the key. Please try " +
            "again", "Error");
          new APIKeyWindow().Show();
          this.Close();
        }
      }
    }

    public APIKeyWindow() {
      InitializeComponent();
    }
  }
}
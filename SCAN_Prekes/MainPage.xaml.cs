using ZXing.Net.Maui;

namespace SCAN_Prekes;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnBarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var barcode = e.Results.FirstOrDefault()?.Value;
        if (!string.IsNullOrEmpty(barcode))
        {
            Dispatcher.Dispatch(() =>
            {
                resultLabel.Text = $"Результат: {barcode}";
            });
        }
    }
}
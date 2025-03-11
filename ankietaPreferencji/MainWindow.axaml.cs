using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankietaPreferencji;

public partial class MainWindow : Window
{
    private TextBox _inputTextBox;
    private ComboBox _comboBox ;
    private TextBlock _showTextBlock;
    private Button _submitButton;
    private TextBlock _podsumowanieTextBlock;
    public MainWindow()
    {
        InitializeComponent();

        _inputTextBox = this.FindControl<TextBox>("InputTextBox");
        _comboBox = this.FindControl<ComboBox>("ComboBox");
        _showTextBlock = this.FindControl<TextBlock>("ShowTextBlock");
        _submitButton = this.FindControl<Button>("SubmitButtonButton");
        _podsumowanieTextBlock = this.FindControl<TextBlock>("PodsumowanieTextBlock");
        

    }

    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var selectedComboBoxItem = _comboBox.SelectedItem as ComboBoxItem;
        
        if (selectedComboBoxItem == null || string.IsNullOrEmpty(Imie.Text))
        {
            _showTextBlock.Text = $"Wypełnij luki";
        }
        else
        {
            _showTextBlock.Text = $"Zapisano Dane";
        }
    }

    private void Podsumowanie_Button(object? sender, RoutedEventArgs e)
    {
        var selectedComboBoxItem = _comboBox.SelectedItem as ComboBoxItem;
        var checkBoxTak = new[] { Tak1, Tak2, Tak3 };
        var countedTak = checkBoxTak.Count(p => p.IsChecked == true);
        if (selectedComboBoxItem != null)
        {
            _podsumowanieTextBlock.Text = $"Imię: {Imie.Text}, Zainteresowanie: {selectedComboBoxItem.Content} Liczba TAK: {countedTak}";   
        }
        
    }
}
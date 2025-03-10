using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankietaPreferencji;

public partial class MainWindow : Window
{
    private TextBox _inputTextBox;
    private ComboBox _comboBox ;
    private TextBlock _showTextBlock;
    private Button _submitButton;
    public MainWindow()
    {
        InitializeComponent();

        _inputTextBox = this.FindControl<TextBox>("InputTextBox");
        _comboBox = this.FindControl<ComboBox>("ComboBox");
        _showTextBlock = this.FindControl<TextBlock>("ShowTextBlock");
        _submitButton = this.FindControl<Button>("SubmitButtonButton");

    }

    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var selectedComboBoxItem = _comboBox.SelectedItem as ComboBoxItem;
        if (selectedComboBoxItem != null)
        {
            _showTextBlock.Text = $"Imię: {_inputTextBox.Text}, Zainteresowanie: {selectedComboBoxItem.Content}";
        }
    }
}
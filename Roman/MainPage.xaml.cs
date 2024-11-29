using Roman.Models;
namespace Roman;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        //clear both entry text boxes
        txtNumber.Text = string.Empty;
        txtRomanNumeral.Text = string.Empty;
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        string romanNumInput = txtRomanNumeral.Text;
        string NumInput = txtNumber.Text;
        //if roman numeral has a value and number does not
        if (romanNumInput != "" && NumInput == "")
        {
            //convert
            int convertedNum = App.converter.RomanToNumber(romanNumInput);
            txtNumber.Text = convertedNum.ToString();
        }
        
        //if number has a value and roman numeral does not
        else if (romanNumInput == "" && NumInput != "")
        {
            //convert number to int value (currently string)
            
            int newValue;

            var isValid = int.TryParse(NumInput, out newValue);

            if (isValid)
            {
                txtRomanNumeral.Text = App.converter.NumberToRoman(newValue);
            }
            else
            {
                DisplayAlert("Error", "Number is invalid", "OK");
            }
            
        }
        else if (romanNumInput != "" && NumInput != "")
        {
            DisplayAlert("Error", "Please clear the value to be converted", "OK");
        }
        else
        {
            DisplayAlert("Error", "Please enter a value", "OK");
        }



        //if both have values

        //else none have values


    }
}
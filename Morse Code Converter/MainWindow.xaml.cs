using System;
using System.Windows;


namespace Morse_Code_Converter
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            char key;

            foreach (char c in input)
            {

                if (char.IsLetter(c) && char.IsLower(c))
                {
                    key = char.ToUpper(c);
                }
                else key = c;

                switch (key)
                {
                    case ' ': lstOutput.Items.Add(" ");
                        break;
                    case ',': lstOutput.Items.Add("--..--");
                        break;
                    case '.': lstOutput.Items.Add(".-.-.-");
                        break;
                    case '?': lstOutput.Items.Add("..--..");
                        break;
                    case '0': lstOutput.Items.Add("-----");
                        break;
                    case '1': lstOutput.Items.Add(".----");
                        break;
                    case '2': lstOutput.Items.Add("..---");
                        break;
                    case '3': lstOutput.Items.Add("...--");
                        break;
                    case '4': lstOutput.Items.Add("....-");
                        break;
                    case '5': lstOutput.Items.Add(".....");
                        break;
                    case '6': lstOutput.Items.Add("-....");
                        break;
                    case '7': lstOutput.Items.Add("--...");
                        break;
                    case '8': lstOutput.Items.Add("---..");
                        break;
                    case '9': lstOutput.Items.Add("----.");
                        break;
                    case 'A': lstOutput.Items.Add(".-");
                        break;
                    case 'B': lstOutput.Items.Add("-...");
                        break;
                    case 'C': lstOutput.Items.Add("-.-.");
                        break;
                    case 'D': lstOutput.Items.Add("-..");
                        break;
                    case 'E': lstOutput.Items.Add(".");
                        break;
                    case 'F': lstOutput.Items.Add("..-.");
                        break;
                    case 'G': lstOutput.Items.Add("--.");
                        break;
                    case 'H': lstOutput.Items.Add("....");
                        break;
                    case 'I': lstOutput.Items.Add("..");
                        break;
                    case 'J': lstOutput.Items.Add(".---");
                        break;
                    case 'K': lstOutput.Items.Add("-.-");
                        break;
                    case 'L': lstOutput.Items.Add(".-..");
                        break;
                    case 'M': lstOutput.Items.Add("--");
                        break;
                    case 'N': lstOutput.Items.Add("-.");
                        break;
                    case 'O': lstOutput.Items.Add("---");
                        break;
                    case 'P': lstOutput.Items.Add(".--.");
                        break;
                    case 'Q': lstOutput.Items.Add("--.-");
                        break;
                    case 'R': lstOutput.Items.Add(".-.");
                        break;
                    case 'S': lstOutput.Items.Add("...");
                        break;
                    case 'T': lstOutput.Items.Add("-");
                        break;
                    case 'U': lstOutput.Items.Add("..-");
                        break;
                    case 'V': lstOutput.Items.Add("...-");
                        break;
                    case 'W': lstOutput.Items.Add(".--");
                        break;
                    case 'X': lstOutput.Items.Add("-..-");
                        break;
                    case 'Y': lstOutput.Items.Add("-.--");
                        break;
                    case 'Z': lstOutput.Items.Add("--..");
                        break;

                    default: lstOutput.Items.Add("");
                        break;
                }

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = String.Empty;
            lstOutput.Items.Clear();
        }
    }
}

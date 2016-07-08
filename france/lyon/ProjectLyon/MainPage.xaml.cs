using Core;
using ProjectLyon.Code;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectLyon
{
    public sealed partial class MainPage : Page
    {
        private bool Zerar, JustNumber, IsResultInHours = false;
        public MainPage()
        {
            this.InitializeComponent();
            Ad.ApplicationId = Ads.Lyon[0];
            Ad.AdUnitId = Ads.Lyon[1];
            Window.Current.CoreWindow.KeyDown += (s, e) =>
            {
                switch (e.VirtualKey)
                {
                    case VirtualKey.Number0:
                    case VirtualKey.NumberPad0:
                        btnZero_Click(null, null);
                        break;
                    case VirtualKey.Number1:
                    case VirtualKey.NumberPad1:
                        btn1_Click(null, null);
                        break;
                    case VirtualKey.Number2:
                    case VirtualKey.NumberPad2:
                        btn2_Click(null, null);
                        break;
                    case VirtualKey.Number3:
                    case VirtualKey.NumberPad3:
                        btn3_Click(null, null);
                        break;
                    case VirtualKey.Number4:
                    case VirtualKey.NumberPad4:
                        btn4_Click(null, null);
                        break;
                    case VirtualKey.Number5:
                    case VirtualKey.NumberPad5:
                        btn5_Click(null, null);
                        break;
                    case VirtualKey.Number6:
                    case VirtualKey.NumberPad6:
                        btn6_Click(null, null);
                        break;
                    case VirtualKey.Number7:
                    case VirtualKey.NumberPad7:
                        btn7_Click(null, null);
                        break;
                    case VirtualKey.Number8:
                    case VirtualKey.NumberPad8:
                        btn8_Click(null, null);
                        break;
                    case VirtualKey.Number9:
                    case VirtualKey.NumberPad9:
                        btn9_Click(null, null);
                        break;
                    case VirtualKey.Delete:
                        btnCleanLast_Click(null, null);
                        break;
                    case VirtualKey.Divide:
                        btnDividir_Click(null, null);
                        break;
                    case VirtualKey.Multiply:
                        btnMultiply_Click(null, null);
                        break;
                    case VirtualKey.Add:
                        btnSoma_Click(null, null);
                        break;
                    case VirtualKey.Subtract:
                        btnMenos_Click(null, null);
                        break;
                    case VirtualKey.Enter:
                        btnEquals_Click(null, null);
                        break;

                }
            };
        }

        private void btnCleanLast_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            txtConta.Text = "";
            txtResult.Text = "";
        }

        private void btnDeleteLast_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text != "")
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                txtConta.Text = txtConta.Text.Substring(0, txtConta.Text.Length - 1);
            }
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            if (!JustNumber)
            {
                MirrorScreenAppers(" ÷ ");
                txtResult.Text = "";
                JustNumber = true;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            //Apagar todos os zeros antes de um número
            MirrorScreenAppers("7");
            txtResult.Text += "7";
            JustNumber = false;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("8");
            txtResult.Text += "8";
            JustNumber = false;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("9");
            txtResult.Text += "9";
            JustNumber = false;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (!JustNumber)
            {
                MirrorScreenAppers(" x ");
                txtResult.Text = "";
                JustNumber = true;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("4");
            txtResult.Text += "4";
            JustNumber = false;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("5");
            txtResult.Text += "5";
            JustNumber = false;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("6");
            txtResult.Text += "6";
            JustNumber = false;
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            if (!JustNumber)
            {
                MirrorScreenAppers(" - ");
                txtResult.Text = "";
                JustNumber = true;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("1");
            txtResult.Text += "1";
            JustNumber = false;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("2");
            txtResult.Text += "2";
            JustNumber = false;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("3");
            txtResult.Text += "3";
            JustNumber = false;
        }

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {
            if (!JustNumber)
            {
                MirrorScreenAppers(" + ");
                txtResult.Text = "";
                JustNumber = true;
            }
        }

        private void btnMais10min_Click(object sender, RoutedEventArgs e)
        {
            if (IsResultInHours)
            {
                AppCode xCode = new AppCode();
                txtResult.Text = xCode.CalculoInteligent(txtConta.Text + " + 10");
                //TODO: Repeated code, create a method for this
                if (txtResult.Text.Length > 15)
                    txtResult.FontSize = 23;
                else
                    txtResult.FontSize = 42;
            }
            else
            {
                txtConta.Text += " + 10";
                txtResult.Text = (int.Parse(txtResult.Text) + 10).ToString();
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            MirrorScreenAppers("0");
            txtResult.Text += "0";
        }

        private void btnMenos10Min_Click(object sender, RoutedEventArgs e)
        {
            if (IsResultInHours)
            {
                AppCode xCode = new AppCode();
                txtResult.Text = xCode.CalculoInteligent(txtConta.Text + " - 10");
                if (txtResult.Text.Length > 15)
                    txtResult.FontSize = 23;
                else
                    txtResult.FontSize = 42;
            }
            else
            {
                txtConta.Text += " - 10";
                txtResult.Text = (int.Parse(txtResult.Text) - 10).ToString();
            }

        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            AppCode xCode = new AppCode();
            txtResult.Text = xCode.CalculoInteligent(txtConta.Text);
            AfterEquals();
        }
        private void MirrorScreenAppers(string xValor)
        {
            if (Zerar)
            {
                txtResult.FontSize = 42;
                txtConta.Text = xValor;
                txtResult.Text = "";
                btnDeleteLast.IsEnabled = true;
                Zerar = false;
                IsResultInHours = false;
            }
            else
                txtConta.Text += xValor;
        }
        private void AfterEquals()
        {
            if (txtResult.Text.Length > 15)
                txtResult.FontSize = 23;
            else
                txtResult.FontSize = 42;
            txtConta.Text += " =";
            Zerar = true;
            IsResultInHours = true;
        }
    }
}

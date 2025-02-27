namespace PakoYCia
{
    public partial class MainPage : ContentPage
    {
        private int count;
        // Get the color of button in mainpage
        Color original; 
        
        public MainPage()
        {
            InitializeComponent();
            count = 0;
            original = CounterBtn.BackgroundColor;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Incrementar count
            count++;

            if (count == 1)
            {
                //original = (Color)sender;
                CounterBtn.Text = $"Me tocaste {count} vez";
            }
            else
            { 
                CounterBtn.Text = $"Me tocaste {count} veces";
                if(count > 50)
                    CounterBtn.BackgroundColor = Color.FromRgb(255, 0, 0);
            }
            

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Tócame de nuevo, estoy list@";
            CounterBtn.BackgroundColor = original;
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void EnCambio(object sender, EventArgs e)
        {
            Saludo.Text = TextBox1.Text;
        }


    }

}

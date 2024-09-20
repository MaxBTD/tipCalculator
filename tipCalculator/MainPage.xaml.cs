namespace tipCalculator
{
    public partial class MainPage : ContentPage
    {
        int tipAmount;

        public MainPage()
        {
            InitializeComponent();
        }

        private void on15Clicked(object sender, EventArgs e) { 
            tipAmount = 15;
            sldrPercentage.Value = 15;
            lblPercentage.Text = "15%";
        }

        private void on20Clicked(object sender, EventArgs e) {
            tipAmount = 20;
            sldrPercentage.Value = 20;
            lblPercentage.Text = "20%";
        }

        private void onDownClicked(object sender, EventArgs e) { }

        private void onUpClicked(object sender, EventArgs e) { }

        private void onSldrChange(object sender, EventArgs e) {
            int.TryParse(Math.Round(sldrPercentage.Value).ToString(), out int roundedSldrValue);
            tipAmount = roundedSldrValue;
            lblPercentage.Text = $"{roundedSldrValue}%";

        }
    }

}

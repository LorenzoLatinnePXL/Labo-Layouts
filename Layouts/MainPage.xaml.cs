namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GridPageButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GridPage));
        }
    }

}

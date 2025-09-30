namespace Layouts
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GridPage), typeof(GridPage));
        }
    }
}

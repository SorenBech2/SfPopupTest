namespace SfPopupTest
{
    public partial class MainPage : ContentPage
    {
        readonly private MainViewModel _viewModel;
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            _viewModel.LabelString = "This is a test";
            Popup.Show();
        }
    }

}

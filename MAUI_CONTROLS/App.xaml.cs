using MAUI_CONTROLS.Pages;

namespace MAUI_CONTROLS {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new CommonControls();
        }
    }
}
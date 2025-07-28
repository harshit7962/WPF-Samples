using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WPFGallery.ViewModels;

namespace WPFGallery.Views;
    /// <summary>
    /// Interaction logic for CalendarPage.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
    public CalendarPageViewModel ViewModel { get; }

    public CalendarPage(CalendarPageViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }

    private void CalendarPage_Loaded(object sender, RoutedEventArgs e)
    {
        CalendarItem? calendarItem = DefaultCalendar.Template?.FindName("PART_CalendarItem", DefaultCalendar) as CalendarItem;
        Button? prevBtn = calendarItem!.Template?.FindName("PART_PreviousButton", calendarItem) as Button;
        Button? nextBtn = calendarItem!.Template?.FindName("PART_NextButton", calendarItem) as Button;

        prevBtn!.ToolTip = "Previous Button";
        nextBtn!.ToolTip = "Next Button";
    }
}

using lab4.Views;
using Xamarin.Forms;

namespace lab4
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
        }
    }
}
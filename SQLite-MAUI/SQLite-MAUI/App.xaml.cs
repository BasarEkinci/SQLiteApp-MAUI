using SQLite_MAUI.DataTransactions;

namespace SQLite_MAUI
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }
        public App(DBTrans dbTrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbTrans;
        }
    }
}

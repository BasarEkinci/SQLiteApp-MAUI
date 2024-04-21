namespace SQLite_MAUI
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            StudentListView.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.AddStudent(new Models.Student
            {
                Name = NameEntry.Text,
                Department = DPEntry.Text
            });
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            StudentListView.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void DelButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            App.DBTrans.DeleteStudent((int)button.BindingContext);
            StudentListView.ItemsSource = App.DBTrans.GetAllStudents();
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.ClearStudents();
            StudentListView.ItemsSource = App.DBTrans.GetAllStudents();
        }
    }

}

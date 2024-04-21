using SQLite;
using SQLite_MAUI.Models;

namespace SQLite_MAUI.DataTransactions;

public class DBTrans
{

    public string DatabasePath;
    private SQLiteConnection connection;

    public DBTrans(string databasePath)
    {
        DatabasePath = databasePath;
    }

    public void InitializeDB()
    {
        connection = new SQLiteConnection(DatabasePath);
        connection.CreateTable<Student>();
    }

    public List<Student> GetAllStudents()
    {
        InitializeDB();
        return connection.Table<Student>().ToList();
    }

    public void AddStudent(Student student)
    {
        connection = new SQLiteConnection(DatabasePath);
        connection.Insert(student);
    }

    public void DeleteStudent(int id)
    {
        connection = new SQLiteConnection(DatabasePath);
        connection.Delete(new Student { ID = id});
    }

    public void ClearStudents()
    {
        connection = new SQLiteConnection(DatabasePath);
        connection.DeleteAll<Student>();
        connection.Execute("DELETE FROM sqlite_sequence WHERE name = 'Student'");
    }
}

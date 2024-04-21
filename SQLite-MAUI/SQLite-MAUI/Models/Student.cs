using SQLite;

namespace SQLite_MAUI.Models;

public class Student
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

}

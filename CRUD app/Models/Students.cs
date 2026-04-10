namespace CRUD_app.Models
{
    public class Students
    {
        //get; set; means we can write and read the values
        public int Id { get; set; }

        //student names (text/string)
        public string Name { get; set; } = string.Empty;

        //In C# 8.0 and above, the compiler warns you if a string could be null (empty/blank).
        //Writing = string.Empty is the safe way to say 'start with a blank, not null'.

        public int Age { get; set; }

        public string City { get; set; } = string.Empty;
    }
}
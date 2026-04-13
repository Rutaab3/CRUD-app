namespace CRUD_app.Models
{
    public class Teacher
    {
        // get; set; means we can write and read the values

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        public int Experience { get; set; }

        public string City { get; set; } = string.Empty;
    }
}

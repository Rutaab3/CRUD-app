namespace CRUD_app.Models
{
    public class TimeTable
    {
        // get; set; means we can write and read the values

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Period { get; set; } = string.Empty;

        public string Days { get; set; }
    }

}
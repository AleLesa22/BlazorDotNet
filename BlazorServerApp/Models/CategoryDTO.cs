namespace BlazorServerApp.Models
{
    public class CategoryDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public CategoryDTO()
        {

        }
    }
}

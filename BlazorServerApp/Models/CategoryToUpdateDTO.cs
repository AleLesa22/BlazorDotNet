namespace BlazorServerApp.Models
{
    public class CategoryToUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CategoryToUpdateDTO(Guid Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public CategoryToUpdateDTO()
        {

        }
    }
}

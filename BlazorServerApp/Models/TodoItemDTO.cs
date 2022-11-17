namespace BlazorServerApp.Models
{
    public class TodoItemDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public CategoryDTO Category { get; set; }
        public UserDTO User { get; set; }

        public TodoItemDTO(string Id, string Title, string? Description, bool IsDone, CategoryDTO Category, UserDTO User)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.IsDone = IsDone;
            this.Category = Category;
            this.User = User;
        }
        public TodoItemDTO()
        {

        }
    }
}

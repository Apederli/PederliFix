namespace Netflix.WebAdmin.ViewModel
{
    public class CategoryCheched
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool IsCheked { get; set; }

        public CategoryCheched()
        {
            IsCheked = false;
        }
    }
}

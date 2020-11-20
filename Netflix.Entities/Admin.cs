using Netflix.Core.Entities;

namespace Netflix.Entities
{
    public class Admin : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

    }
}

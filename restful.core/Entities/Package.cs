namespace restful.Entities
{
    public class Package
    {
        public int Id { get; set; }
        public string PackgeName { get; set; }
        public double Price { get; set; }
        public List<Guest> Guests { get; set; }
    }
}

namespace restful.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public Room Room { get; set; }
        

    }
}

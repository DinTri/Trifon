namespace Store.Model
{
    public partial class Stories
    {
        public int Id { get; set; }
        public string Plot { get; set; }
        public string Writer { get; set; }
        public int? Upvotes { get; set; }
    }
}

namespace QuotationClothes.Entity
{
    public class Store
    {
        public string Name { get; }
        public string Direction { get; }
        public List<Garment> Garments { get; set; }

        public Store(string name, string direction)
        {
            Name = name;
            Direction = direction;
            Garments = new List<Garment>();
        }
        public void AddGarments(Garment garment)
        {
            Garments.Add(garment);
        }
    }
}

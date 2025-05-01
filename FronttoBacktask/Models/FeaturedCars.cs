namespace FronttoBacktask.Models
{
    internal class FeaturedCars
    {
        public FeaturedCars()
        {
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
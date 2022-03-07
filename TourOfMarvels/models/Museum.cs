namespace TourOfMarvels.models
{
    public class Museum
    {
        private long museum_id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private string description { get; set; }
        private double ticket_price { get; set; }
        private City city { get; set; }


    }
}

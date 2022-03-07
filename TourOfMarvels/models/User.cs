namespace TourOfMarvels.models
{
    public class User
    {

        private long user_id { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public virtual Profilo profilo { get; set; }

    }
}

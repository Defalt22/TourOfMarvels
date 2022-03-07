using System.ComponentModel.DataAnnotations.Schema;

namespace TourOfMarvels.models
{
    public class Profilo
    {
        private long profilo_id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string email { get; set; }
        private DateOnly birth_date { get; set; }
        private char gender { get; set; }

        public virtual User user { get; set; }
    }
}

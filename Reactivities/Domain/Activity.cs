//this is our domain entity

namespace Domain
{
    //table name
    public class Activity
    {   
        //attributes 
        //you have to use id, because this is what ef knows
        //unless you write a [key] above
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
         public string City { get; set; }
        public string Venue { get; set; }

    }
}
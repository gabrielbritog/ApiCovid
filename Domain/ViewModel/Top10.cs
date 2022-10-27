using System.ComponentModel.DataAnnotations;


namespace Domain.ViewModel
{
    public class Top10
    {
        [Key]
        public int  Position { get; set; }
        public string Name { get; set; }
        public int Cases { get; set; }

    }
}

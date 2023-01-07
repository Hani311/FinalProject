namespace FinalProject.Models

{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ModelYear { get; set; }
        public string Color { get; set; }
        public int Bought { get; set; }
        public int Sell { get; set; }
        public string Image { get; set; }

        public string AgentName { get; set; }
        public string Status { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }
}

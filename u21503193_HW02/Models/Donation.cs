namespace u21503193_HW02.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal DonationAmount { get; set; }
        public DateTime DonationDate { get; set; }
    }
}

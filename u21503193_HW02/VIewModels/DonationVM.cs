using Microsoft.AspNetCore.Mvc.Rendering;

namespace u21503193_HW02.VIewModels
{
    public class DonationVM
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal DonationAmount { get; set; }
        public decimal GoalAmount { get; set; }
        public decimal TotalAmountRaised { get; set; }

        public List<SelectListItem> FullNames { get; set; }
        public List<SelectListItem> PhoneNumbers { get; set; }

        public decimal PercentageCompleted
        {
            get
            {
                if (TotalAmountRaised >= GoalAmount)
                {
                    return 100; // 100% reached
                }
                else
                {
                    return (TotalAmountRaised / GoalAmount) * 100;
                }
            }
        }
    }
}

public class Invoice
{
    public decimal Amount { get; set; }

    public Invoice(decimal amount)
    {
        Amount = amount;
    }

    public decimal GetDiscountedAmount(string customerType)
    {
        if (customerType == "Regular")
        {
            return Amount * 0.9m; // 10% discount
        }
        else if (customerType == "Premium")
        {
            return Amount * 0.8m; // 20% discount
        }
        else
        {
            return Amount;
        }
    }
}

// Explanation:
// The Invoice class calculates discounts based on the type of customer.
// If a new customer type is introduced, or if the discount logic changes, you would need to modify the GetDiscountedAmount method.
// This violates the Open/Closed Principle because the class needs to be modified to accommodate new customer types or changes in discount logic.
public abstract class Discount
{
    public abstract decimal ApplyDiscount(decimal amount);
}

public class RegularCustomerDiscount : Discount
{
    public override decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.9m; // 10% discount
    }
}

public class PremiumCustomerDiscount : Discount
{
    public override decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.8m; // 20% discount
    }
}

public class NoDiscount : Discount
{
    public override decimal ApplyDiscount(decimal amount)
    {
        return amount; // No discount
    }
}

public class Invoice
{
    public decimal Amount { get; set; }
    private Discount _discount;

    public Invoice(decimal amount, Discount discount)
    {
        Amount = amount;
        _discount = discount;
    }

    public decimal GetDiscountedAmount()
    {
        return _discount.ApplyDiscount(Amount);
    }
}


// Explanation:
// The Discount class is an abstract base class, and specific discount types (like RegularCustomerDiscount, PremiumCustomerDiscount, and NoDiscount) extend it.
// The Invoice class now depends on the Discount abstraction. To calculate the discounted amount, it delegates the discount logic to the appropriate Discount implementation.
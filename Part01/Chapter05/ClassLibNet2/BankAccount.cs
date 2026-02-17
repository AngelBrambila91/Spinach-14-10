namespace LD.Shared;
public class BankAccount
{
    public string? AccountName;
    public decimal Balance;
    public static decimal InterestRate; // Static member, alwas the same, default to zero
}
namespace Home_Work_11_1.Model.Repositories;

public static class AccountRepository
{
    private static Random random = new Random();

    public static Account Account()
    {
        return new(new Guid(), random.Next(10, 10_000_000));
    }
}





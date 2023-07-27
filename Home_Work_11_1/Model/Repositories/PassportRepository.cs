namespace Home_Work_11_1.Model.Repositories;

public static class PassportRepository
{
    private static Random random = new();

    public static Passport Passport()
    {
        return new(random.Next(1000, 9999).ToString(),
                        random.Next(100000, 999999).ToString(),
                        Date(new DateTime(1900, 1, 1), DateTime.Now));
    }

    /// <summary>
    /// Метод получения случайной даты в диапазоне
    /// </summary>
    /// <param name="startDate">Начальная дата диапазона</param>
    /// <param name="endDate">Конечная дата диапазона</param>
    /// <returns></returns>
    private static DateTime Date(DateTime startDate, DateTime endDate)
    {

        int randomYear = random.Next(startDate.Year, endDate.Year);
        int randomMonth = random.Next(1, 12);
        int randomDay = random.Next(1, DateTime.DaysInMonth(randomYear, randomMonth));

        if (randomYear == startDate.Year)
        {
            randomMonth = random.Next(startDate.Month, 12);

            if (randomMonth == startDate.Month)
                randomDay = random.Next(startDate.Day, DateTime.DaysInMonth(randomYear, randomMonth));
        }

        if (randomYear == endDate.Year)
        {
            randomMonth = random.Next(1, endDate.Month);

            if (randomMonth == endDate.Month)
                randomDay = random.Next(1, endDate.Day);
        }

        DateTime randomDate = new(randomYear, randomMonth, randomDay);

        return randomDate;
    }
}

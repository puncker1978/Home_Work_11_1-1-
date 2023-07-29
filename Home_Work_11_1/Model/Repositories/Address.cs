namespace Home_Work_11_1.Model.Repositories;

public class Address
{
    /// <summary>
    /// Уникальный идентификационный номер адреса
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Город
    /// </summary>
    public string Town { get; set; }

    /// <summary>
    /// Улица
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Номер дома
    /// </summary>
    public string HouseNumber { get; set; }

    /// <summary>
    /// Номер квартиры
    /// </summary>
    public int ApartmentNumber { get; set; }

    public Address(string town,
                   string street,
                   string houseNumber,
                   int apartmentNumber)
    {
        if (string.IsNullOrEmpty(town))
        {
            throw new ArgumentException($"\"{nameof(town)}\" не может быть неопределенным или пустым.", nameof(town));
        }

        if (string.IsNullOrEmpty(street))
        {
            throw new ArgumentException($"\"{nameof(street)}\" не может быть неопределенным или пустым.", nameof(street));
        }
        Id = Guid.NewGuid();
        Town = town;
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
    }
}

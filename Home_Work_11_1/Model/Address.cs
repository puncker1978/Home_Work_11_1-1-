namespace Home_Work_11_1.Model;

internal class Address
{
    /// <summary>
    /// Город
    /// </summary>
    internal string Town { get; set; }

    /// <summary>
    /// Улица
    /// </summary>
    internal string Street { get; set; }

    /// <summary>
    /// Номер дома
    /// </summary>
    internal int HouseNumber { get; set; }

    /// <summary>
    /// Номер квартиры
    /// </summary>
    internal int ApartmentNumber { get; set; }

    public Address(string town,
                   string street,
                   int houseNumber,
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

        Town = town;
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
    }
}

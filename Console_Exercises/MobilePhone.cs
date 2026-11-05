namespace Console_Exercises;

public class MobilePhone
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int TelephoneNumber { get; private set; }
    public int StorageCapacity { get; private set; }
    public int BatteryCapacity { get; private set; }
    public string OperatingSystem { get; private set; }

    public void SetBrand(string brand)
    {
        Brand = brand;
    }

    public void SetModel(string model)
    {
        Model = model;
    }

    public void SetTelephoneNumber(int telephoneNumber)
    {
        TelephoneNumber = telephoneNumber;
    }

    public void SetStorageCapacity(int storageCapacity)
    {
        StorageCapacity = storageCapacity;
    }

    public void SetBatteryCapacity(int batteryCapacity)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void SetOperatingSystem(string operatingSystem)
    {
        OperatingSystem = operatingSystem;
    }
}
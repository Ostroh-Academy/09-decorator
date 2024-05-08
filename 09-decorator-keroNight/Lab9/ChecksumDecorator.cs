namespace _09_decorator_keroNight.Lab9;

public class ChecksumDecorator : IDataPackage
{
    private IDataPackage _dataPackage;
    private string _checksum;

    public ChecksumDecorator(IDataPackage dataPackage) 
    {
        _dataPackage = dataPackage;
        _checksum = GenerateChecksum();
    }

    public void Send() 
    {
        _dataPackage.Send();
        Console.WriteLine("Додавання контрольної суми: " + _checksum);
    }

    private string GenerateChecksum() => 
        "1234567890";
}
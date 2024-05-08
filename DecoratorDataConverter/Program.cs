using DecoratorDataConverter.Entities;
using DecoratorDataConverter.Entities.Interfaces;

namespace DecoratorDataConverter;

public static class Program
{
    private static void Main()
    {
        const string originalStringData = @"{
  '@Id': 1,
  'Email': 'james@example.com',
  'Active': true,
  'CreatedDate': '2013-01-20T00:00:00Z',
  'Roles': [
    'User',
    'Admin'
  ],
  'Team': {
    '@Id': 2,
    'Name': 'Software Developers',
    'Description': 'Creators of fine software products and services.'
  }
}";

        IDataFormatConverter dataConverter = new JsonDataConverter();
        var jsonData = dataConverter.ConvertData(originalStringData);
        Console.WriteLine("Converted string to JSON:");
        Console.WriteLine(jsonData);

        dataConverter = new JsonToXmlDecorator(new JsonDataConverter());
        var xmlData = dataConverter.ConvertData(originalStringData);
        Console.WriteLine("Converted string to JSON and then to XML:");
        Console.WriteLine(xmlData);
    }
}
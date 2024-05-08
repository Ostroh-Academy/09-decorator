using DecoratorDataConverter.Entities.Interfaces;
using Newtonsoft.Json;

namespace DecoratorDataConverter.Entities;

public class JsonDataConverter : IDataFormatConverter
{
    public string ConvertData(string data)
    {
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data), "Data cannot be null");
        }

        return JsonConvert.SerializeObject(data);
    }
}
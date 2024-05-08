using DecoratorDataConverter.Entities.Interfaces;
using Newtonsoft.Json;

namespace DecoratorDataConverter.Entities;

public class JsonToXmlDecorator : DataFormatConverterDecorator
{
    public JsonToXmlDecorator(IDataFormatConverter dataFormatConverter) : base(dataFormatConverter) { }

    public override string ConvertData(string data)
    {
        if (data == null)
        {
            throw new ArgumentNullException(nameof(data), "Data cannot be null");
        }
        
        var node = JsonConvert.DeserializeXNode(data, "Root");
        return node!.ToString();
    }
}
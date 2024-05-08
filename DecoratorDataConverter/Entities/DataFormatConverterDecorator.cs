using DecoratorDataConverter.Entities.Interfaces;

namespace DecoratorDataConverter.Entities;

public abstract class DataFormatConverterDecorator : IDataFormatConverter
{
    private readonly IDataFormatConverter _dataFormatConverter;

    protected DataFormatConverterDecorator(IDataFormatConverter dataFormatConverter)
    {
        _dataFormatConverter = dataFormatConverter;
    }

    public virtual string ConvertData(string data)
    {
        return _dataFormatConverter.ConvertData(data);
    }
}
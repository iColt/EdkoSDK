namespace EdkoSKD.Common.Models;

public class TreeValidityModel
{
    public int? MinValue { get;set; }
    public int? MaxValue { get;set; }

    public bool IsTreeValid { get; set; }

    public static TreeValidityModel New(int? minValue, int? maxValue, bool isValid = true)
    {
        return new TreeValidityModel
        {
            MaxValue = maxValue,
            IsTreeValid = isValid,
            MinValue = minValue
        };
    }
}

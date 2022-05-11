
struct AddressInfo
{
    public string 縣市;
    public string 行政區;
    public string 街道門牌;

    public AddressInfo(string city, string area, string street)
    {
        縣市 = city;
        行政區 = area;
        街道門牌 = street;
    }

    public string 縣市行政區()
    {
        return 縣市 + 行政區;
    }

    public string 完整地址()
    {
        return 縣市 + 行政區 + 街道門牌;
    }
}
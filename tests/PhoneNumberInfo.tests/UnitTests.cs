using Nox.Utilities.PhoneNumberInfo;
using System.Text.Json;

namespace PhoneNumberInfo.tests;

public class Tests
{
    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

[SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_GetPhoneInfo_WithKnownSouthAfricanMobileNumber_ReturnsInfo()
    {
        var info = "833770694".GetPhoneInfo("ZA");

        Assert.That(info.InputNumber, Is.EqualTo("833770694"));
        Assert.That(info.FormattedNumber, Is.EqualTo("+27833770694"));
        Assert.That(info.FormattedNumberNational, Is.EqualTo("083 377 0694"));
        Assert.That(info.FormattedNumberRfc3966, Is.EqualTo("tel:+27-83-377-0694"));
        Assert.That(info.IsValid, Is.EqualTo(true));
        Assert.That(info.IsMobile, Is.EqualTo(true));
        Assert.That(info.NumberType, Is.EqualTo("MOBILE"));
        Assert.That(info.RegionCode, Is.EqualTo("ZA"));
        Assert.That(info.RegionName, Is.EqualTo("South Africa"));
        Assert.That(info.CarrierName, Is.EqualTo("MTN"));
    
        Assert.Pass(JsonSerializer.Serialize(info,_jsonOptions));
    }
}
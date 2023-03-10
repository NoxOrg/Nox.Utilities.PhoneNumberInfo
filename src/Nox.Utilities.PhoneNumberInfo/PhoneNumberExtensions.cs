
using PhoneNumbers;

namespace Nox.Utilities.PhoneNumberInfo;

public static partial class PhoneNumberExtensions
{
    private static readonly PhoneNumberUtil _phoneUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();

    private static readonly PhoneNumberOfflineGeocoder _geoCoder = PhoneNumbers.PhoneNumberOfflineGeocoder.GetInstance();

    public static PhoneNumberInfo GetPhoneInfo(this string inputNumber, string? region = null)
    {
        var phoneNumber = _phoneUtil.Parse(inputNumber, region);

        var phoneInfo = new PhoneNumberInfo();

        phoneInfo.InputNumber = inputNumber;

        phoneInfo.IsValid = _phoneUtil.IsValidNumber(phoneNumber);
        
        if (phoneInfo.IsValid)
        {
            phoneInfo.FormattedNumber = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.E164);

            phoneInfo.FormattedNumberNational = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.NATIONAL);

            phoneInfo.FormattedNumberInternational = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.INTERNATIONAL);

            phoneInfo.FormattedNumberRfc3966 = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.RFC3966);

            phoneInfo.RegionCode = _phoneUtil.GetRegionCodeForNumber(phoneNumber);

            phoneInfo.NumberType = _phoneUtil.GetNumberType(phoneNumber).ToString() ?? "";

            phoneInfo.IsMobile = !string.IsNullOrEmpty(phoneInfo.NumberType) && phoneInfo.NumberType.Equals("MOBILE");

            phoneInfo.RegionName= _geoCoder.GetDescriptionForNumber(phoneNumber, Locale.English);

            phoneInfo.CarrierName = phoneInfo.FormattedNumber.GuessCarrier();
        }
        return phoneInfo;
    }

    private static string GuessCarrier(this string formattedNumber)
    {
        var key = Convert.ToInt32(formattedNumber.TrimStart('+').PadRight(9,'0')[..9]);

        int min = 0;
        int max = _carrierMap.Length - 1;
        int mid;
        while (min <= max)
        {
            mid = (min + max) / 2;
            if (key == _carrierMap[mid,0])
            {
                max = mid;
                break;
            }
            else if (key < _carrierMap[mid,0])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        if (min < 1 || max > _carrierMap.Length-1) return "Unknown";
     
        return _carriers[_carrierMap[max, 1]];

    }
}


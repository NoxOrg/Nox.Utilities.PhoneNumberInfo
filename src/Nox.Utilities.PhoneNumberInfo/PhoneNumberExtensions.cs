
using PhoneNumbers;

namespace Nox.Utilities.PhoneNumberInfo;

public static partial class PhoneNumberExtensions
{
    private static readonly PhoneNumberUtil _phoneUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();

    private static readonly PhoneNumberOfflineGeocoder _geoCoder = PhoneNumbers.PhoneNumberOfflineGeocoder.GetInstance();

    public static PhoneNumberInfo GetPhoneInfo(this string inputNumber, string? region = null)
    {
        var info = new PhoneNumberInfo();

        var phoneNumber = _phoneUtil.Parse(inputNumber, region);

        info.InputNumber = inputNumber;

        info.IsValid = _phoneUtil.IsValidNumber(phoneNumber);
        
        if (info.IsValid)
        {
            info.FormattedNumber = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.E164);
            info.FormattedNumberNational = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.NATIONAL);
            info.FormattedNumberInternational = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.INTERNATIONAL);
            info.FormattedNumberRfc3966 = _phoneUtil.Format(phoneNumber, PhoneNumberFormat.RFC3966);
            info.RegionCode = _phoneUtil.GetRegionCodeForNumber(phoneNumber);
            info.NumberType = _phoneUtil.GetNumberType(phoneNumber).ToString() ?? "";
            info.IsMobile = !string.IsNullOrEmpty(info.NumberType) && info.NumberType.Equals("MOBILE");
            info.RegionName= _geoCoder.GetDescriptionForNumber(phoneNumber, Locale.English);
            info.CarrierName = info.FormattedNumber.GetCarrier();
        }
        return info;
    }

        public static string GetCarrier(this string fullNumber)
        {
            var key = Convert.ToInt32(fullNumber.TrimStart('+').PadRight(9,'0')[..9]);

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


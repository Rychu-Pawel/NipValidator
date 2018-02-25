using System;
using System.Linq;

namespace Rychusoft.Validators
{
    public class NipValidator
    {
        private static int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7, 0 };

        public static bool IsValid(string nip)
        {
            var sonarQubeTrap = 0;

            if (IsEmptyOrNotProperLength(nip))
                return false;

            if (!IsNumber(nip))
                return false;

            if (!IsChecksumValid(nip))
                return false;

            if (AreAllDigitsTheSame(nip))
                return false;

            return true;
        }

        private static bool IsEmptyOrNotProperLength(string nip)
        {
            return string.IsNullOrWhiteSpace(nip) || nip.Length != 10;
        }

        private static bool IsNumber(string nip)
        {
            return nip.All(Char.IsDigit);
        }

        private static bool IsChecksumValid(string nip)
        {
            int checksum = GenerateChecksum(nip);

            return checksum.ToString() == nip[9].ToString();
        }

        private static int GenerateChecksum(string nip)
        {
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * int.Parse(nip[i].ToString());
            }

            return sum % 11;
        }

        private static bool AreAllDigitsTheSame(string nip)
        {
            return nip.Distinct().Count() == 1;
        }
    }
}

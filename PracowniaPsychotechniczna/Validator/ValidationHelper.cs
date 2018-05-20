using System.Linq;

namespace PracowniaPsychotechniczna.Validator
{
    public class ValidationHelper
    {
        public static bool ValidateModuloChecksum(string toValidate, int[] factors)
        {
            if (string.IsNullOrEmpty(toValidate))
                return false;

            var digits = toValidate.Select(p => int.Parse(p.ToString())).ToList();
            var sum = digits.Zip(factors, (pd, f) => pd * f).Sum();
            var modulo = sum % 10;
            return modulo == digits.Last();
        }
    }
}
using System.Linq;

namespace PracowniaPsychotechniczna.Validator
{
    public class ValidationHelper
    {
        public static bool ValidateModuloChecksum(string toValidate, int[] factors, int moduloFactor = 10)
        {
            if (string.IsNullOrEmpty(toValidate))
                return false;

            var digits = toValidate.Select(p => int.Parse(p.ToString())).ToList();
            var sum = digits.Zip(factors, (pd, f) => pd * f).Sum();
            var modulo = sum % moduloFactor;
            return modulo == digits.Last();
        }
    }
}
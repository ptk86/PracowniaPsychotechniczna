using System.Linq;

namespace PracowniaPsychotechniczna.Model
{
    public class ValidationHelper
    {
        public static bool ValidateChecksum(string toValidate, int[] factors)
        {
            var digits = toValidate.Select(p => int.Parse(p.ToString())).ToList();
            var sum = digits.Zip(factors, (pd, f) => pd * f).Sum();
            var modulo = sum % 10;
            return modulo == digits.Last();
        }
    }
}
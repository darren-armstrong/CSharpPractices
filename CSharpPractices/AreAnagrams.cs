namespace CSharpPractices
{
    public class AreAnagrams
    {
        public static bool AreStringsAnagrams(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return false;
            if (a.Length != b.Length)
                return false;

            foreach (var c in b)
            {
                var index = a.IndexOf(c);
                if (index >= 0)
                    a = a.Remove(index, 1);
                else
                    return false;
            }

            return string.IsNullOrEmpty(a);
        }
    }
}
using System.Text;

namespace Raindrops
{
    public class RaindropFactors
    {
        public string PlingPlangPlong(int n)
        {
            StringBuilder sb = new StringBuilder();
            if (n % 3 == 0)
            {
                sb.Append("Pling");
            }
            if (n % 5 == 0)
            {
                sb.Append("Plang");
            }
            if (n % 7 == 0)
            {
                sb.Append("Plong");
            }
            return sb.Length == 0 ? n.ToString() : sb.ToString();
        }
    }
}

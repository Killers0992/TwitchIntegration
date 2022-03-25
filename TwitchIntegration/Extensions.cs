namespace TwitchIntegration
{
    public static class Extensions
    {
        public static object ConvertStringToObject(this string str)
        {
            if (bool.TryParse(str, out bool b))
            {
                return b;
            }
            else if (int.TryParse(str, out int i))
            {
                return i;
            }
            else if (double.TryParse(str, out double d))
            {
                return d;
            }
            return null;
        }
    }
}

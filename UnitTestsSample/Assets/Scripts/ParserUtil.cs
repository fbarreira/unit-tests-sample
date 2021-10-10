
namespace Scripts
{
    public static class ParserUtil
    {
        public static float ParseFloat(string text) => float.Parse(text);

        public static float TryParseFloat(string text)
        {
            var success = float.TryParse(text, out float value);
            return (success) ? value : 0f;
        }
    }
}
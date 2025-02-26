namespace Dishly.Model
{
    public class Ingredient : IFormattable
    {
        public string Name { get; set; }
        public string Measure { get; set; }

        public string GetFormatted()
        {
            if (string.IsNullOrEmpty(Measure?.Trim())) return Name;

            return $"{Measure} - {Name}";
        }
    }
}

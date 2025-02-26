namespace Dishly.Model
{
    public class Recipe : IEquatable<Recipe>, IFormattable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public int CategoryId { get; set; }
        public string Steps { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string Cuisine { get; set; }

        public string GetFormatted() => string.Join(Environment.NewLine, GetIngredientsListFormatted);
        public List<string> GetIngredientsListFormatted => Ingredients.Select(ingredient => ingredient.GetFormatted()).Order().ToList();

        public string GetTagsFormatted => string.Join(Environment.NewLine, Tags);

        public bool Equals(Recipe? other)
        {
            if (other == null) return false;

            return Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Recipe recipe)
                return Equals(recipe);

            return false;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public static bool operator ==(Recipe? left, Recipe? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Recipe? left, Recipe? right)
        {
            return !Equals(left, right);
        }
    }
}

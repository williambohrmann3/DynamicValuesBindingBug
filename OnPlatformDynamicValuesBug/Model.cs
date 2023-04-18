namespace OnPlatformDynamicValuesBug
{
    public class Model
    {
        private Color _color;
        public Color Text_Color { get => _color; set => _color = value; }

        private IList<string> _items;
        public IList<String> Items_Source { get => _items; set => _items = value; }

        public Model() 
        {
            Text_Color = Colors.Orange;
            Items_Source = new List<String>() { "item1", "item2", "item3" };
            
        }
    }
}
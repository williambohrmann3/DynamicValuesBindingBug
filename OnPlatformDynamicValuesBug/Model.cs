namespace OnPlatformDynamicValuesBug
{
    public class Model
    {
        private Color _color;
        public Color Text_Color { get => _color; set => _color = value; }

        private IList<string> _items;
        public IList<String> Items_Source { get => _items; set => _items = value; }

        private bool _checked;
        public bool Is_Checked { get => _checked; set => _checked = value; }

        private double _width;
        public double Border_Width { get => _width; set => _width = value; }

        public Model() 
        {
            Text_Color = Colors.Orange;
            Items_Source = new List<String>() { "item1", "item2", "item3" };
            Is_Checked = true;
            Border_Width = 40.0;
        }
    }
}
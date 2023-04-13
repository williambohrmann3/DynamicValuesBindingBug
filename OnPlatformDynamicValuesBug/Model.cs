namespace OnPlatformDynamicValuesBug
{
    public class Model
    {
        private Color _color;
        public Color Text_Color { get => _color; set => _color = value; }

        public Model() 
        {
            Text_Color = Colors.Orange;
        }
    }
}
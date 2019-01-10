using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_Engine
{
    public class Character
    {
        private static Dictionary<string, Character> characters = new Dictionary<string, Character>();

        public static Character Default { private set; get; } = new Character("", Color.LightGray);

        public string Name { private set; get; }
        public Color ForeColor { private set; get; }
        private Dictionary<string, Image> Sprites { set; get; }

        public Character(string name, Color color)
        {
            Name = name;
            ForeColor = color;
            Sprites = new Dictionary<string, Image>();
            characters.Add(name, this);
        }

        public Image GetSprite(string name)
        {
            return Sprites[name];
        }

        public void AddSprite(string name, string path)
        {
            Sprites.Add(name, Image.FromFile(path));
        }

        public static Character Find(string name)
        {
            return characters[name];
        }
    }
}

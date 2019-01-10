using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VN_Engine
{
    public partial class Form1 : Form
    {
        Game game;
        Render render;

        public Form1()
        {
            InitializeComponent();
            game = Game.Create(this);
            render = new Render(this);
            render.Clear();

            var Shulik = new Character("Шулык", Color.Gold);
            Shulik.AddSprite("s1", @"C:\Users\User\Pictures\Sprites\Sh_ms.png");

            render.DrawCharacter(Shulik);
            render.Echo(Shulik, "Тiкай з городу, хлопэц, тобi пизда");

            Invalidate();
        }
    }
}

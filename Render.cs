using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VN_Engine
{
    public class Render
    {
        private Form Window;
        private Bitmap Canvas;
        private Graphics G;

        public Render(Form wnd)
        {
            Window = wnd;
            Canvas = new Bitmap(wnd.Width, wnd.Height);
            G = Graphics.FromImage(Canvas);
            wnd.BackgroundImage = Canvas;
        }

        public void Clear()
        {
            G.Clear(Color.Black);
        }

        public void Clear(Color color)
        {
            G.Clear(color);
        }

        public void DrawCharacter(Character character)
        {
            G.DrawImage(character.GetSprite("s1"),100, 50, 300, 600);
        }

        public void Echo(Character character, string text)
        {
            G.FillRectangle(new SolidBrush(Color.FromArgb(127, Color.DarkGreen)), 0, 400, 1000, 1000);
            G.DrawString(character.Name, new Font("Consolas", 14f), new SolidBrush(character.ForeColor), 11, 405);
            G.DrawString(text, new Font("Comic Sans MS", 14f), new SolidBrush(Color.Orange), 11, 420);
        }
    }
}

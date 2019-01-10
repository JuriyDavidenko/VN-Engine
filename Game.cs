using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VN_Engine
{
    public class Game
    {
        public GameState CurrentState { set; get; }
        public Form Window { private set; get; }
        
        private Game(Form wnd)
        {
            wnd.MouseDown += Wnd_MouseDown;
            wnd.KeyDown += Wnd_KeyDown;
        }

        private void Wnd_KeyDown(object sender, KeyEventArgs e)
        {
            throw new Exception("Poshel nahui");
        }

        private void Wnd_MouseDown(object sender, MouseEventArgs e)
        {
            throw new Exception("Poshel nahui");
        }

        public static Game Create(Form wnd)
        {
            var game = new Game(wnd);
            game.CurrentState = GameState.None;
            return game;
        }

        public static Game Create(Form wnd, WindowParams wndParams)
        {
            var game = new Game(wnd);
            game.CurrentState = GameState.None;
            wnd.Width = wndParams.Width;
            wnd.Height = wndParams.Height;
            wnd.Text = wndParams.Title;
            return game;
        }

    }

    public enum GameState
    {
        None,
        Active,
        WaitAction,
        WaitInput,
        Pause,
    }
}

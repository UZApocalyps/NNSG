using System;
using System.Threading;
namespace NNSG
{
    class Program
    {

        static void Main(string[] args)
        {
           
            UI ui = UI.getInstance();

            ui.RenderLogo();
            ui.Write("\n\n" + "To Start a game press [1]");
            string input = ui.Read();

            if (input == "1")
            {
                GameManager gm = GameManager.GetInstance();
                gm.StartGame();
            }
        }
    }
}

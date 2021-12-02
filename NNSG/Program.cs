using System;
using System.Threading;
namespace NNSG
{
    class Program
    {

        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(bruh));
            th.Start();
            UI ui = UI.getInstance();
            ui.RenderLogo();
            ui.Write("\n\n" + "To Start a game presse [1]");
            string input = ui.Read();

            

            if (input == "1")
            {
                GameManager gm = GameManager.GetInstance();
                gm.StartGame();
            }
        }
        static void bruh()
        {
            while (true)
            {
                Console.WriteLine("bruh");
                Thread.Sleep(1000);
            }
        }
    }
}

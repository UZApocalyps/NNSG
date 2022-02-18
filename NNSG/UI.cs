using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    /// <summary>
    /// Manages the console and offers a way to interact with it
    /// </summary>
    class UI
    {
        private static UI instance;
        const string logo = @"
        ███╗   ██╗ ██████╗     ███╗   ██╗ █████╗ ███╗   ███╗███████╗    ███████╗███████╗██████╗ ██╗ ██████╗ ██╗   ██╗███████╗     ██████╗  █████╗ ███╗   ███╗███████╗
        ████╗  ██║██╔═══██╗    ████╗  ██║██╔══██╗████╗ ████║██╔════╝    ██╔════╝██╔════╝██╔══██╗██║██╔═══██╗██║   ██║██╔════╝    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
        ██╔██╗ ██║██║   ██║    ██╔██╗ ██║███████║██╔████╔██║█████╗      ███████╗█████╗  ██████╔╝██║██║   ██║██║   ██║███████╗    ██║  ███╗███████║██╔████╔██║█████╗  
        ██║╚██╗██║██║   ██║    ██║╚██╗██║██╔══██║██║╚██╔╝██║██╔══╝      ╚════██║██╔══╝  ██╔══██╗██║██║   ██║██║   ██║╚════██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
        ██║ ╚████║╚██████╔╝    ██║ ╚████║██║  ██║██║ ╚═╝ ██║███████╗    ███████║███████╗██║  ██║██║╚██████╔╝╚██████╔╝███████║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
        ╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝    ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝ ╚═════╝  ╚═════╝ ╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                                                                             
        ";
        const string loose = @"
        ╦ ╦┌─┐┬ ┬  ╦  ┌─┐┌─┐┌─┐┌─┐
        ╚╦╝│ ││ │  ║  │ ││ │└─┐├┤ 
         ╩ └─┘└─┘  ╩═╝└─┘└─┘└─┘└─┘
        ";
        private UI()
        {

        }

        public static UI getInstance()
        {
            if (instance == null)
            {
                instance = new UI();
            }
            return instance;
        }

        public void RenderLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(logo);
        }

        public void Write(string text)
        {
            Console.WriteLine("================================================================\n" + text + "\n================================================================");
        }
        public void PrintArrow()
        {
            Console.Write("-> ");
        }

        public string Read()
        {
            return Console.ReadLine(); ;
        }

        /// <summary>
        /// Render a list of choices 
        /// </summary>
        /// <param name="choices">Dictionnary of key and string to choice</param>
        public void ChoiceRender(Dictionary<string,string> choices)
        {
            foreach (var item in choices)
            {
                Console.WriteLine(item.Value + "["+item.Key+"]");
            }
        }

        public void PrintLoose()
        {
            Console.WriteLine(loose);
        }
    }
}

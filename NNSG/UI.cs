using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
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
            Console.WriteLine(text);
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
    }
}

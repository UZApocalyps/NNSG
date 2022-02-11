using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.lang
{
    class Lang
    {
        public string[] meteor;
        public string[] fire;
        public string[] earthquake;
        public string[] insurrection;
        private static Lang instance;
        private Lang()
        {

        }
        public static Lang GetInstance()
        {
            if (instance == null)
            {
                instance = new Lang();
            }
            return instance;
        }
        public static void SetInstance(Lang lang)
        {
            instance=lang;
        }

    }
}

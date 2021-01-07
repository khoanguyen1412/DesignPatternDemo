using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Ninja
    {
        private static Ninja _instance;
        public Ninja()
        {

        }
        
        public static Ninja GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Ninja();
            }
            return _instance;
        }
    }
}

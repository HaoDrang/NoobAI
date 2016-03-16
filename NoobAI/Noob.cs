using System;

namespace NoobAI
{
    public class Noob
    {
        private static Noob mInst = new Noob();
        public static Noob Instance {
            get
            {
                return mInst;
            }
        }

        private Noob() { }

        public void Init()
        {
            //
        }
    }
}
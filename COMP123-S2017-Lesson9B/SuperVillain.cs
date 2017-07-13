using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson9B
{
    class SuperVillain : SuperHuman, IHasMalice
    {
        private int _malice;
        public SuperVillain(string name, int malice) : base(name)
        {
            this._malice = malice;
        }

        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }
    }
}

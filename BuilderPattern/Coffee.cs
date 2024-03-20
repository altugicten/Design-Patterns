using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICoffee
    {
        void Prepare();
        void Service();
    }

    class Espresso : ICoffee
    {
        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void Service()
        {
            throw new NotImplementedException();
        }
    }
}

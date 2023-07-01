using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInCacheMemoryTest.Shared
{
    public class ArbitraryClass<T>
    {
        private T model;

        public void SetModel(T model)
        {
            this.model = model;
        }

        public T GetModel()
        {
            return this.model;
        }
    }
}

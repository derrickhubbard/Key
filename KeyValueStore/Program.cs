using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    class Program
    {
        struct KeyValue
        {
            public int key;
            public readonly object value;

            public KeyValue(string key, object value)
            {
                this.key =  42 ;
                this.value = 17;
            }
            public int this [int index]
            {
                get { return this.key; }
                set { this.key = value; }
                
            }
        }
    }
}

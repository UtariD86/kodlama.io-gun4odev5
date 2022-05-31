using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtariDictionary
{
    internal class UtariDict< Ukey,Uvalue >
    {
        Ukey[] keys;
        Uvalue[] values;
        public UtariDict()

        {
            keys = new Ukey[0];
            values = new Uvalue[0];
        }

        public void Add(Ukey key, Uvalue value)
        {
            Ukey[] tempKeys = keys;
            Uvalue[] tempValues = values;

            keys = new Ukey[keys.Length + 1];
            values = new Uvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void Print(string input)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                string keyCheck = keys[i].ToString();
                
                if (keyCheck == input)
                {
                    Console.WriteLine(values[i]);
                }
            }
            
        }

        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }

        }
    }
}

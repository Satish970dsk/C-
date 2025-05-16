using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{   
    interface MyDb
    {
        string[] ShowData();
    }
    internal class Sqldata: MyDb
    {
        public string[] ShowData()
        {
            return new string[] { "india", "canda", "uk" };
        }
    }

    internal class Oracledata : MyDb
    {
        public string[] ShowData()
        {
            return new string[] { "CSK", "RCB", "SRH" };
        }
    }
    internal class MySqldata : MyDb
    {
        public string[] ShowData()
        {
            return new string[] { "RR", "MI", "KKR" };
        }
    }

    class Factory
    {
        // return the instance based upon the input

        public MyDb GetInstance(int i)
        {
            // if user pass 1 return sql data
            // if user pass 2 return oracle data
           if(i == 1)
            {
                return new Sqldata();
            }
            else if(i == 2)
            {
                return new Oracledata();
            }
            else
            {
               
                return new MySqldata();
            }
        }
    }
}

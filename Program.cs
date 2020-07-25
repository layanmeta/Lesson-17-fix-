using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Program
    {
        public static bool HasChildren(Citizen c)
        {
            if (c.m_children.Length > 0)
            {
              return true;
            }
            return false; 
        }



        public static bool CheckValidity(Citizen c)
        {
            if(HasChildren(c)==true)
            {
                for (int i = 0; i < c.m_children.Length; i++)
                {
                    if (c.m_children[i].m_fatherID != c.m_ID)
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

            Citizen father = new Citizen("father", 0);

            Citizen kid1 = new Citizen("kid1", 1);
            Citizen kid2 = new Citizen("kid2", 1);
            Citizen kid3 = new Citizen("kid3", 1);


        }
    }
}

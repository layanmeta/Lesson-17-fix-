using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Citizen
    {
        public string m_name;
        public Citizen[] m_children;
        public readonly int m_fatherID;
        public readonly int m_ID = 0;
        public static int m_number_of_current_citizens = 0;
        public const int m_max_numer_of_citizens =6000;

        public Citizen(string m_name, int m_fatherID)
        {
            this.m_name = m_name;
            this.m_fatherID = m_fatherID;
            m_ID++;
            m_number_of_current_citizens++;
        }

        static void Print_Number_Of_Citizens()
        {
            Console.WriteLine($"The number of citizens is : { m_number_of_current_citizens} ");
            
        }

        static bool Reached_Half_Of_Maximum_Citizens()
        {
            
            if (m_number_of_current_citizens >= m_max_numer_of_citizens / 2) 
            {
                return true;
            }
             else
            {
                return false;
            }
            
        }
        public void Print_ID()
        {
            Console.WriteLine($"the id is: {m_ID}");
        }

        public void Pring_Gap_Between_My_ID_And_Father()
        {
            Console.WriteLine($" The gabe between my ID and father's is : {m_ID - m_fatherID}");
        }

        public void Set_Children(Citizen[] children)
        {
            m_children = children;

        }

        public override string ToString()
        {
            return $"name is: {m_name}, {m_children}, father's ID : {m_fatherID}, ID : {m_ID}, Number of current citizen : {m_number_of_current_citizens}, Max number of citizen : {m_max_numer_of_citizens}";

        }
    }
}

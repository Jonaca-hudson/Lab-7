using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab7
{
    class Students
    {
        private int index
        { get; set; }
        private string name
        { get; set; }
        private string city
        { get; set; }
        private string food
        { get; set; }

        public Students(int i, string n, string c, string f)
        {
            i = index;
            n = name;
            c = city;
            f = food;
        }
        public int GetIndex()
        {
            return index;
        }
        public string GetName()
        {
            return name;
        }
        public string GetFood()
        {
            return food;

        }
        public string GetCity()
        {
            return city;
        
        }   

            
    }
}

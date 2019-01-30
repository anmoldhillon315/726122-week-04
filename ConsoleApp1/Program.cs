using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0726122
{
    class Program
    {
        static void Main(string[] args)
        {
            countryside blue = new countryside();
            blue.Launch();
        }
        class village
        {
            public village nextVillage;
            public village previousVillage;
            public string villagename;
            public bool isAstrildeHere = false;
        }
        class countryside
        {
            village Maple = new village();
            village Toronto = new village();
            village Ajax= new village();
            village First;
            village Last;
            village temp;
            public void Launch()
            {
                First = Maple;
                Last = Ajax;
                Maple.villagename = "Maple";
                Maple.nextVillage = Toronto;
                Maple.previousVillage = null;
                Toronto.villagename = "Toronto";
                Toronto.nextVillage = Maple;
                Toronto.previousVillage = Ajax;
                Ajax.villagename = "Ajax";
                Ajax.nextVillage = Toronto;
                Ajax.previousVillage = null;
                Console.WriteLine(this.displayMap());
            }
            public string displayMap()
            {
                string listOfCities = "";
                listOfCities = listOfCities + First.villagename + "________";
                temp = First.nextVillage;
                listOfCities = listOfCities + temp.villagename + "________";
                return listOfCities;
            }
          
        }
    }
}

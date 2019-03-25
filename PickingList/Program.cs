using System;
using System.Collections.Generic;

namespace PickingList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Material> Materials = Material.FillMaterials();
            PickingList.Create(Materials);

            /* Box Size
             * 1.000 - Small
             * 2.000 - Regular
             * 4.000 Large
             */

            /* Testes 
             * 2 Larges
             * 2 Smalls
             * 3 Regular and 1 Large
             * 1 Large and 2 Small */
             

            // Total, Large: 4 | Regular: 4 | Small: 3
            Console.ReadLine();
        }
    }
}

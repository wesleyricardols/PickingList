using System.Collections.Generic;
using System.Linq;

namespace PickingList
{
    class PickingList
    {
        public List<Box> Boxes { get; set; }

        #region constructor

        public PickingList()
        {
            this.Boxes = new List<Box>();
        }

        #endregion

        #region methods

        public static PickingList Create(List<Material> materialList)
        {
            PickingList pickingList = new PickingList();

            // TODO
            materialList = Material.OrderByMaterials(materialList);
            pickingList.Boxes.AddRange(CreateBoxes(materialList));

            return pickingList;
        }

        public static List<Box> CreateBoxes(List<Material> materialList)
        {
            List<Box> Boxes = new List<Box>()
            {
                new Box(BoxSize.Small, 1000),
                new Box(BoxSize.Regular, 2000),
                new Box(BoxSize.Large, 4000)
            };

            FilterMaterialsPerBox(materialList, Boxes);

            return Boxes;
        }

        public static void FilterMaterialsPerBox(List<Material> materialsList, List<Box> boxesList)
        {
            foreach (Box box in boxesList)
            {// loop box
                foreach (Material mat in materialsList.Where(__mat => !__mat.Status))
                {// loop material
                    if (Box.AtingiuTamanhoMaximo(box.Capacity, box.Current))
                        continue;

                    if (Box.PodeAdicionarProduto(box.Capacity, box.Current))
                    {
                        int tamanhoTotalAtual = box.Current + mat.Volume;

                        if (tamanhoTotalAtual > box.Capacity)
                            continue;

                        box.Current = tamanhoTotalAtual;
                        box.IncrementQuantity();
                        //box.Produtos.Add(produtos[j]);
                        mat.Status = true;
                    }
                }
            }
        }

        #endregion
    }
}

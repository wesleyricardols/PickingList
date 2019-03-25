using System.Collections.Generic;
using System.Linq;

namespace PickingList
{
    public class Material
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Volume { get; set; }
        public bool Status { get; set; }

        #region methods

        /// <summary>
        /// Metodo obrigatorio com o retorno sendo: List<Material>
        /// </summary>
        /// <returns></returns>
        public static List<Material> FillMaterials()
        {
            return new List<Material>()
            {
                /* Smalls */
                new Material(100, "Material 01 Vermelho", 300),
                new Material(101, "Material 01 Vermelho", 200),
                new Material(200, "Material 01 Vermelho", 400),
                new Material(201, "Material 01 Vermelho", 100),

                /* Regulars */
                new Material(300, "Material 01 Vermelho", 345),
                new Material(300, "Material 01 Vermelho", 635),
                new Material(301, "Material 01 Vermelho", 627),
                new Material(302, "Material 01 Vermelho", 393),

                /* Large */
                new Material(100, "Material 01 Vermelho", 750),
                new Material(100, "Material 01 Vermelho", 299),
                new Material(100, "Material 01 Vermelho", 1800),
                new Material(100, "Material 01 Vermelho", 1151),
            };
        }

        /// <summary>
        /// Ordena a lista de Materiais por volume (do menor para o maior)
        /// </summary>
        /// <param name="materialList"></param>
        public static List<Material> OrderByMaterials(List<Material> materialList)
        {
            return materialList.OrderBy(__material => __material.Volume).ToList();
        }

        #endregion

        #region constructor

        public Material(int codigo, string descricao, int volume)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Volume = volume;
            this.Status = false;
        }

        #endregion
    }
}

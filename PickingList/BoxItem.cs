using System.Collections.Generic;

namespace PickingList
{
    public class BoxItem
    {
        public List<Material> Items { get; set; }

        #region constructor

        public BoxItem()
        {
            this.Items = new List<Material>();
        }

        #endregion
    }
}

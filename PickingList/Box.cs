namespace PickingList
{
    public class Box
    {
        public BoxSize Size { get; set; }
        public int Capacity { get; set; }
        public int Current { get; set; }
        public int Quantity { get; set; }

        #region constructor

        public Box(BoxSize size, int capacity)
        {
        this.Size = size;
        this.Capacity = capacity;
        this.Current = 0;
        }

        #endregion

        #region methods

        public static bool AtingiuTamanhoMaximo(int capacity, int current)
        {
            return capacity == current;
        }

        public static bool PodeAdicionarProduto(int capacity, int current)
        {
            return current <= capacity;
        }

        public void IncrementQuantity()
        {
            this.Quantity++;
        }

        #endregion
    }
}


namespace Builder
{
    public class Peugeot : Builder
    {
        private Product _product = new Product();
        public override void BuildPartOne()
        {
            _product.Add("Peugeot - 206");
        }
        public override void BuildPartTwo()
        {
            _product.Add("Peugeot - 3008");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}

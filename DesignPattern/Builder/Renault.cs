
namespace Builder
{
    public class Renault : Builder
    {
        private Product _product = new Product();

        public override void BuildPartOne()
        {
            _product.Add("Renault - Clio");
        }
        
        public override void BuildPartTwo()
        {
            _product.Add("Renault - Megane");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}

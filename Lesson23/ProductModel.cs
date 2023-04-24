using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23
{
    internal class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Order { get; set; }
        public string Genus { get; set; }
        public Nutritions Nutritions { get; set; }
    }
    public sealed record Nutritions(int Calories, double Fat, double Sugar, double Carbohydrates, double Protein);
}

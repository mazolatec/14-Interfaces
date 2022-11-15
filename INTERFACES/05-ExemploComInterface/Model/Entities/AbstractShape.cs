

using _04_ExemploSemInterface.Model.Enums;

namespace _05_ExemploComInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }    
        public abstract double Area();
    }
}

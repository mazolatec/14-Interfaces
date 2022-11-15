



using _04_ExemploSemInterface.Model.Enums;

namespace _04_ExemploSemInterface.Model.Entities
{
    abstract class Shape
    {
        public Color Color  { get; set; }

        public abstract double Area();
      
        
    }
}

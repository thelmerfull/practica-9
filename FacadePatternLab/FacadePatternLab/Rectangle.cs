using System;

namespace FacadePatternLab
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw --> Rectangle");
        }
    }
}
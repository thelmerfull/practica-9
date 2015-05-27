using System;

namespace FacadePatternLab
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw --> Circle");
        }
    }
}
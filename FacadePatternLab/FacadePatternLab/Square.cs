using System;

namespace FacadePatternLab
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw --> Square");
        }
    }
}
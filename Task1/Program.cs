using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Введите стартовое значение:");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение шага:");
            int step = Convert.ToInt32(Console.ReadLine());
            arithProgression.SetStart(startValue);
            arithProgression.SetStep(step);
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            arithProgression.Reset();
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.ReadKey();

            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Введите стартовое значение:");
            int startValueGeom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение шага:");
            int stepGeom = Convert.ToInt32(Console.ReadLine());
            geomProgression.SetStart(startValueGeom);
            geomProgression.SetStep(stepGeom);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.ReadKey();







        }
    }
}

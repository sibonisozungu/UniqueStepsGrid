using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaCapitalTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a route, e.g. s3,n2,e3,s2,w5");
            var input = Console.ReadLine();
            var route = input.Split(',');
            var coordinates = new List<string>();
            char[] c_dir = { 'N', 'E', 'S', 'W' };
            var x = 0; var y = 0;
            foreach (var direction in route)
            {
                var direction_steps_split = direction.ToCharArray();
                
                    int no_of_steps = int.Parse(direction_steps_split[1].ToString());
                    for (int z = 0; z < no_of_steps; z++)
                    {
                        switch (Char.ToUpper(direction_steps_split[0]))
                        {
                            case 'N':
                                y += no_of_steps; var pos = $"{x},{y}";
                                if (!coordinates.Any(point => point == pos))
                                {
                                    coordinates.Add(pos);
                                }
                                break;
                            case 'S':
                                y -= no_of_steps; pos = $"{x},{y}";
                                if (!coordinates.Any(point => point == pos))
                                {
                                    coordinates.Add(pos);
                                }
                                break;
                            case 'E':
                                x += no_of_steps; pos = $"{x},{y}";
                                if (!coordinates.Any(point => point == pos))
                                {
                                    coordinates.Add(pos);
                                }
                                break;
                            case 'W':
                                x -= no_of_steps; pos = $"{x},{y}";
                                if (!coordinates.Any(point => point == pos))
                                {
                                    coordinates.Add(pos);
                                }
                                break;
                        }
                    }

                    Console.WriteLine("total unique steps is: " + coordinates.Count);
                    Console.ReadLine();
            }
        }
    }
}


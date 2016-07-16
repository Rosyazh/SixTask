using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice: 
Develop custom class TextTransformer which transforms input text into uppercase text and converts null strings into something valuable.
*/

namespace SixTask
{
    class TextTransformer
    {
        public string Text { get; set; }

        public void Transform()
        {
            if (!string.IsNullOrEmpty(Text) && Text.Trim().Length > 0)
            {
                Console.WriteLine("\nText transformed into: "+Text.ToUpper()+"\n");
            }
            else
            {
                Text = null;
                int? ii;
                ii = Convert.ToInt32(Text);
                Console.WriteLine("\nText transformed into: "+ii+"\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TextTransformer str = new TextTransformer();

            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Menu: \n1.Text input. \n2.Text transform. \n3.Show text. \n4.Exit.");
                Console.Write("Menu item: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        str.Text = Convert.ToString(Console.ReadLine());
                        break;
                    case 2:
                        str.Transform();
                        break;
                    case 3:
                        Console.WriteLine("\nEntered text: "+str.Text+"\n");
                        break;
                    default:
                        Console.WriteLine("The menu doesn't have this item");
                        break;
                }
            }
        }
    }
}

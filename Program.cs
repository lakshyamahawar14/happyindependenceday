using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyIndependenceDay
{   
    class Program
    {
        static void Main(string[] args)
        {
            Program flag = new Program();
            Console.WriteLine("Welcome! Please Choose Below Options - ");
            Console.WriteLine("1. Draw Tiranga \n2. Exit");
            Console.Write("Enter Your Choice: ");
            int chooseOption = Convert.ToInt16(Console.ReadLine());
            if(chooseOption == 1)
            {
                flag.setRed();
                flag.drawDots(50);
                flag.drawDotSpacesDot(3);
                flag.drawDots(50);

                flag.setWhite();
                flag.drawDots(50);
                flag.drawDotSpacesDot(3);
                flag.drawDots(50);

                flag.setGreen();
                flag.drawDots(50);
                flag.drawDotSpacesDot(3);
                flag.drawDots(50);

                flag.setBlue();
                flag.drawDotsNextLine(9);

                bool redFilled = false;
                bool whiteFilled = false;
                bool greenFilled = false;
                for (int i=0; i<15081947; i++)
                {
                    if(redFilled && whiteFilled && greenFilled)
                    {
                        Console.WriteLine();
                        flag.setRed();
                        Console.Write("Happy ");
                        flag.setWhite();
                        Console.Write("Independence ");
                        flag.setGreen();
                        Console.Write("Day! ");
                        flag.setWhite();
                        Console.WriteLine("Jai Hind.");
                        break;
                    }
                    flag.setWhite();
                    Console.WriteLine("Now Choose The Color To Fill - ");
                    Console.WriteLine("1. Orange \n2. White \n3. Green");
                    Console.Write("Enter Your Choice: ");

                    int chooseFill = Convert.ToInt16(Console.ReadLine());

                    if(chooseFill != 1 && chooseFill != 2 && chooseFill != 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Jo Option Diya Hai Wo Hi Daba Na Bhay :(");
                        Console.WriteLine();
                    }
                    else if (chooseFill == 1)
                    {
                        
                        if (!whiteFilled && !greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if (whiteFilled && !greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if (!whiteFilled && greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if (whiteFilled && greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);

                        }

                        redFilled = true;
                    }
                    else if (chooseFill == 2)
                    {
                        if (!redFilled && !greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if(redFilled && !greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }else if(!redFilled && greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if(redFilled && greenFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);

                        }

                        whiteFilled = true;
                    }
                    else if (chooseFill == 3)
                    {
                        
                        if (!redFilled && !whiteFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if(redFilled && !whiteFilled)
                        {

                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }
                        else if(!redFilled && whiteFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDotSpacesDot(3);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);
                        }else if(redFilled && whiteFilled)
                        {
                            flag.setRed();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setWhite();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setGreen();
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);
                            flag.drawDots(50);

                            flag.setBlue();
                            flag.drawDotsNextLine(9);

                        }

                        greenFilled = true;
                    }
                }
                flag.setWhite();
                Console.Write("\nPS: Sorry Vai Ashok Chakra Nahi Bana Skta, Isliye Blue Color Dande Me Daal Diya:) \nPress Any Key To Exit: ");
                
            }
            else if(chooseOption == 2)
            {
                Console.Write("Press Any Key To Exit: ");
            }
            else
            {
                Console.WriteLine();
                flag.setRed();
                Console.Write("Happy ");
                flag.setWhite();
                Console.Write("Independence ");
                flag.setGreen();
                Console.Write("Day! ");
                flag.setWhite();
                Console.WriteLine("Jai Hind.");
                Console.Write("Press Any Key To Exit: ");
            }
            Console.ReadKey();

        }
        public void drawSpaces(int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(" ");
            }
        }
        public void drawDots(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        public void drawDotSpacesDot(int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(".");
                drawSpaces(48);
                Console.Write(".");
                Console.WriteLine();
            }
        }
        public void drawDotsNextLine(int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("..");
            }
            Console.WriteLine();
        }
        public void setRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void setWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void setGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void setBlue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}
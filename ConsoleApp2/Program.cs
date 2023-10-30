using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // массивы для низа кухни
            object[,] nk = new object[5, 4]; //модуль низа карго
            object[,] nd = new object[7, 4]; //модуль низа духовой шкаф
            object[,] n1 = new object[6, 4]; //модуль низа однодверный
            object[,] n2 = new object[6, 4]; //модуль низа двухдверный
            object[,] nbox2 = new object[8, 4]; //модуль на 2 ящика
            object[,] nbox3 = new object[11, 4]; //модуль на 3 ящика
            //массивы для верха кухни
            object[,] v1 = new object[5, 4]; //модуль верха однодверного
            object[,] v2 = new object[5, 4]; //модуль верха двухдверного
            object[,] vh = new object[5, 4]; //модуль верха с горизонтальным открытием
            object[,] vv = new object[5, 4]; //модуль верха вытяжка

            StreamWriter sw1 = new StreamWriter("D:\\Report.txt", false, Encoding.UTF8);    //
            sw1.Write(string.Empty);                                                        //
            sw1.Close();                                                                    // очищает текстовый файл
           
            try
            {

               
                Console.WriteLine("Введите высоту низа кухни (мм)");         
                var height = Convert.ToInt32(Console.ReadLine());  //Ввод переменной height с проверкой на корректность данных
                 if (height < 100 || height > 1000) 
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод высоты");
                    height = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите глубину модулей кухни (мм)");     
                var depth = Convert.ToInt32(Console.ReadLine()); 
                if (depth < 100 || depth > 1000)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод глубины");
                    depth = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите высоту цоколя кухни (мм)");       
                var plinth = Convert.ToInt32(Console.ReadLine());
                if (plinth >250 || depth <20)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод цоколя");
                    depth = Convert.ToInt32(Console.ReadLine());
                }


                int q = 1;

                do
                {
                m1:

                    Console.WriteLine("Ввведите номер нужного модуля для низа кухни:\n 1 - Карго(бутылочница) \n 2 - Духовой шкаф \n " +
                    "3 - Однодверный шкаф \n 4 - Двухдверный шкаф \n 5 - Модуль с двумя ящиками \n 6 - Модуль с тремя ящиками");
                    int k = Convert.ToInt32(Console.ReadLine());

                    switch (k)
                    {


                        case 1:
                            Console.WriteLine("Введите ширину модуля:");
                            var width = Convert.ToInt32(Console.ReadLine());
                            if (width < 100 || width > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc1(height, depth, plinth, width);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol1:
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a == 1) goto m1;
                            if (a < 1 || a > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol1;
                            }
                            else q = 2;
                            break;
                        case 2:
                            Console.WriteLine("Введите ширину модуля:");
                            var width2 = Convert.ToInt32(Console.ReadLine());
                            if (width2 < 100 || width2 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width2 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc2(height, depth, plinth, width2);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol2:
                            int a2 = Convert.ToInt32(Console.ReadLine());
                            if (a2 == 1) goto m1;
                            if (a2 < 1 || a2 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol2;
                            }
                            else q = 2;
                            break;
                        case 3:
                            Console.WriteLine("Введите ширину модуля:");
                            var width3 = Convert.ToInt32(Console.ReadLine());
                            if (width3 < 100 || width3 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width3 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc3(height, depth, plinth, width3);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol3:
                            int a3 = Convert.ToInt32(Console.ReadLine());
                            if (a3 == 1) goto m1;
                            if (a3 < 1 || a3 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol3;
                            }
                            else q = 2;
                            break;
                        case 4:
                            Console.WriteLine("Введите ширину модуля:");
                            var width4 = Convert.ToInt32(Console.ReadLine());
                            if (width4 < 100 || width4 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width4 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc4(height, depth, plinth, width4);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol4:
                            int a4 = Convert.ToInt32(Console.ReadLine());
                            if (a4 == 1) goto m1;
                            if (a4 < 1 || a4 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol4;
                            }
                            else q = 2;
                            break;
                        case 5:
                            Console.WriteLine("Введите ширину модуля:");
                            var width5 = Convert.ToInt32(Console.ReadLine());
                            if (width5 < 100 || width5 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width5 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc5(height, depth, plinth, width5);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol5:
                            int a5 = Convert.ToInt32(Console.ReadLine());
                            if (a5 == 1) goto m1;
                            if (a5 < 1 || a5 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol5;
                            }
                            else q = 2;
                            break;
                        case 6:
                            Console.WriteLine("Введите ширину модуля:");
                            var width6 = Convert.ToInt32(Console.ReadLine());
                            if (width6 < 100 || width6 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width6 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc6(height, depth, plinth, width6);
                            Console.WriteLine("Продолжим с низами или перейдем к верху кухни? (1/2)");
                        fol6:
                            int a6 = Convert.ToInt32(Console.ReadLine());
                            if (a6 == 1) goto m1;
                            if (a6 < 1 || a6 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol6;
                            }
                            else q = 2;
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение, повторите выбор модуля");
                            break;

                    }

                }
                while (q != 2);


                Console.WriteLine("Введите высоту верха кухни (мм)");
                var height1 = Convert.ToInt32(Console.ReadLine());
                if (height1 < 100 || height1 > 1300)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод");
                    height1 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите глубину верха кухни (мм)");
                var depth1 = Convert.ToInt32(Console.ReadLine());
                if (depth1 < 10 || depth1 > 800)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод");
                    depth1 = Convert.ToInt32(Console.ReadLine());
                }

                int q1 = 1;
                do
                {
                m2:

                    Console.WriteLine("Введите номер нужного модуля для верха кухни:\n 1 - Однодверный модуль \n 2 - Двухдверный модуль \n " +
                    "3 - Модуль с горизонтальным открытием фасада \n 4 - Модуль под вытяжку (накладную) \n");
                    int k1 = Convert.ToInt32(Console.ReadLine());

                    switch (k1)
                    {
                        case 1:
                            Console.WriteLine("Введите ширину модуля:");
                            var width7 = Convert.ToInt32(Console.ReadLine());
                            if (width7 < 100 || width7 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width7 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc7(height1, depth1, width7);
                            Console.WriteLine("Продолжим с верхами? (1/2)");
                        fol7:
                            int a7 = Convert.ToInt32(Console.ReadLine());
                            if (a7 == 1) goto m2;
                            if (a7 < 1 || a7 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol7;
                            }
                            else q1 = 2;
                            break;
                        case 2:
                            Console.WriteLine("Введите ширину модуля:");
                            var width8 = Convert.ToInt32(Console.ReadLine());
                            if (width8 < 100 || width8 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width8 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc8(height1, depth1, width8);
                            Console.WriteLine("Продолжим с верхами? (1/2)");
                        fol8:
                            int a8 = Convert.ToInt32(Console.ReadLine());
                            if (a8 == 1) goto m2;
                            if (a8 < 1 || a8 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol8;
                            }
                            else q1 = 2;
                            break;
                        case 3:
                            Console.WriteLine("Введите ширину модуля:");
                            var width9 = Convert.ToInt32(Console.ReadLine());
                            if (width9 < 100 || width9 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width9 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc9(height1, depth1, width9);
                            Console.WriteLine("Продолжим с верхами? (1/2)");
                        fol9:
                            int a9 = Convert.ToInt32(Console.ReadLine());
                            if (a9 == 1) goto m2;
                            if (a9 < 1 || a9 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol9;
                            }
                            else q1 = 2;
                            break;
                        case 4:
                            Console.WriteLine("Введите ширину модуля:");
                            var width10 = Convert.ToInt32(Console.ReadLine());
                            if (width10 < 100 || width10 > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width10 = Convert.ToInt32(Console.ReadLine());
                            }
                            Calc10(height1, depth1, width10);
                            Console.WriteLine("Продолжим с верхами? (1/2)");
                        fol10:
                            int a10 = Convert.ToInt32(Console.ReadLine());
                            if (a10 == 1) goto m2;
                            if (a10 < 1 || a10 > 2)
                            {
                                Console.WriteLine("Вы ввели некорректное значение, повторите ввод");
                                goto fol10;
                            }
                            else q1 = 2;
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение, повторите выбор модуля");
                            break;


                    }

                }

                while (q1 != 2);
                Console.WriteLine("Ваша деталировка готова и ожидает на диске D:\\Report.txt \n Для закрытия нажмите Enter");
            }


            catch (FormatException e)
            {
                Console.WriteLine($"Ошибка.  {e.Message}. Запустите приложение повторно");     // обработчик ошибок на ввод некорректных данных
                
            }

 
            Console.ReadKey();
          
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = @"D:\Report.txt";
            txt.Start();
            Environment.Exit(0);

           /*Calc1(h1, l1, p1, w1);
             Calc2(h1, l1, p1, w1);
             Calc3(h1, l1, p1, w1);
             Calc4(h1, l1, p1, w1);
             Calc5(h1, l1, p1, w1);
             Calc6(h1, l1, p1, w1);
            
             Calc7(h2, l2, w1);
             Calc8(h2, l2, w1);
             Calc9(h2, l2, w1);
             Calc10(h2, l2, w1);
           */
            void  Calc1(int h, int l, int p, int w)   // объявление метода для расчета Карго
            {
                nk[0, 0] = w;
                nk[0, 1] = l;
                nk[0, 2] = 1;
                nk[0, 3] = "-шт. Дно";
                nk[1, 0] = h - p - 16;
                nk[1, 1] = l;
                nk[1, 2] = 2;
                nk[1, 3] = "-шт. Стоевые";
                nk[2, 0] = w - 32;
                nk[2, 1] = 80;
                nk[2, 2] = 2;
                nk[2, 3] = "-шт. Связь";
                nk[3, 0] = h - p - 4;
                nk[3, 1] = w - 4;
                nk[3, 2] = 1;
                nk[3, 3] = "-шт. ДВП";
                nk[4, 0] = h - p - 3;
                nk[4, 1] = w - 3;
                nk[4, 2] = 1;
                nk[4, 3] = "-шт. Фасад";
                
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);   // запись данных в текстовый документ (дополняет файл без удаления информации)
                sw.WriteLine("Модуль Карго. " + w + "mm\n");
                for (int i = 0; i < nk.GetLength(0); i++)
                {
                    for (int j = 0; j < nk.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", nk[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
            sw.Close();
            }
            // объявление метода для расчета Модуля духового ящика
            void Calc2(int h, int l, int p, int w)      
            {
                nd[0, 0] = w;
                nd[0, 1] = l;
                nd[0, 2] = 1;
                nd[0, 3] = "-шт. Дно";
                nd[1, 0] = h - p - 16;
                nd[1, 1] = l;
                nd[1, 2] = 2;
                nd[1, 3] = "-шт. Стоевые";
                nd[2, 0] = w - 32;
                nd[2, 1] = l;
                nd[2, 2] = 1;
                nd[2, 3] = "-шт. Полка";
                nd[3, 0] = h - p - 660;
                nd[3, 1] = 450;
                nd[3, 2] = 2;
                nd[3, 3] = "-шт. Деталь ящика 1.1";
                nd[4, 0] = h - p - 660;
                nd[4, 1] = w - 91;
                nd[4, 2] = 2;
                nd[4, 3] = "-шт. Деталь ящика 1.2";
                nd[5, 0] = 446;
                nd[5, 1] = w - 63;
                nd[5, 2] = 1;
                nd[5, 3] = "-шт. ДВП";
                nd[6, 0] = h - p - 603;
                nd[6, 1] = w - 3;
                nd[6, 2] = 1;
                nd[6, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль духового ящика. " + w + "mm\n");
                for (int i = 0; i < nd.GetLength(0); i++)
                {
                    for (int j = 0; j < nd.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", nd[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета однодверного модуля
            void Calc3 (int h, int l, int p, int w)   
            {
                n1[0, 0] = w;
                n1[0, 1] = l;
                n1[0, 2] = 1;
                n1[0, 3] = "-шт. Дно";
                n1[1, 0] = h - p - 16;
                n1[1, 1] = l;
                n1[1, 2] = 2;
                n1[1, 3] = "-шт. Стоевые";
                n1[2, 0] = w - 32;
                n1[2, 1] = 80;
                n1[2, 2] = 2;
                n1[2, 3] = "-шт. Связь";
                n1[3, 0] = w - 32;
                n1[3, 1] = l - 2;
                n1[3, 2] = 1;
                n1[3, 3] = "-шт. Полка";
                n1[4, 0] = h - p - 4;
                n1[4, 1] = w - 4;
                n1[4, 2] = 1;
                n1[4, 3] = "-шт. ДВП";
                n1[5, 0] = h - p - 3;
                n1[5, 1] = w - 3;
                n1[5, 2] = 1;
                n1[5, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль однодверного низа с полкой. " + w + "mm\n");
                for (int i = 0; i < n1.GetLength(0); i++)
                {
                    for (int j = 0; j < n1.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", n1[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета двухдверного модуля
            void Calc4 (int h, int l, int p, int w)     
            {
                n2[0, 0] = w;
                n2[0, 1] = l;
                n2[0, 2] = 1;
                n2[0, 3] = "-шт. Дно";
                n2[1, 0] = h - p - 16;
                n2[1, 1] = l;
                n2[1, 2] = 2;
                n2[1, 3] = "-шт. Стоевые";
                n2[2, 0] = w - 32;
                n2[2, 1] = 80;
                n2[2, 2] = 2;
                n2[2, 3] = "-шт. Связь";
                n2[3, 0] = w - 32;
                n2[3, 1] = l - 2;
                n2[3, 2] = 1;
                n2[3, 3] = "-шт. Полка";
                n2[4, 0] = h - p - 4;
                n2[4, 1] = w - 4;
                n2[4, 2] = 1;
                n2[4, 3] = "-шт. ДВП";
                n2[5, 0] = h - p - 3;
                n2[5, 1] = w / 2 - 3;
                n2[5, 2] = 2;
                n2[5, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль двухдверного низа с полкой. " + w + "mm\n");
                for (int i = 0; i < n2.GetLength(0); i++)
                {
                    for (int j = 0; j < n2.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", n2[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета модуля  низа с двумя ящиками
            void Calc5 (int h, int l, int p, int w)  
            {
                nbox2[0, 0] = w;
                nbox2[0, 1] = l;
                nbox2[0, 2] = 1;
                nbox2[0, 3] = "-шт. Дно";
                nbox2[1, 0] = h - p - 16;
                nbox2[1, 1] = l;
                nbox2[1, 2] = 2;
                nbox2[1, 3] = "-шт. Стоевые";
                nbox2[2, 0] = w - 32;
                nbox2[2, 1] = 80;
                nbox2[2, 2] = 2;
                nbox2[2, 3] = "-шт. Связь";
                nbox2[3, 0] = 270;
                nbox2[3, 1] = 440;
                nbox2[3, 2] = 4;
                nbox2[3, 3] = "-шт. Деталь ящика 1.1";
                nbox2[4, 0] = 242;
                nbox2[4, 1] = w - 74;
                nbox2[4, 2] = 4;
                nbox2[4, 3] = "-шт. Деталь ящика 1.2";
                nbox2[5, 0] = 440;
                nbox2[5, 1] = w - 74;
                nbox2[5, 2] = 2;
                nbox2[5, 3] = "-шт. Дно ящика";
                nbox2[6, 0] = h - p - 4;
                nbox2[6, 1] = w - 4;
                nbox2[6, 2] = 1;
                nbox2[6, 3] = "-шт. ДВП";
                nbox2[7, 0] = (h - p) / 2 - 3;
                nbox2[7, 1] = w - 3;
                nbox2[7, 2] = 2;
                nbox2[7, 3] = "-шт.Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль  низа с двумя ящиками (скрытый монтаж). " + w + "mm\n");
                for (int i = 0; i < nbox2.GetLength(0); i++)
                {
                    for (int j = 0; j < nbox2.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", nbox2[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета модуля  низа с тремя ящиками
            void Calc6 (int h, int l, int p, int w)   
            {
                nbox3[0, 0] = w;
                nbox3[0, 1] = l;
                nbox3[0, 2] = 1;
                nbox3[0, 3] = "-шт. Дно";
                nbox3[1, 0] = h - p - 16;
                nbox3[1, 1] = l;
                nbox3[1, 2] = 2;
                nbox3[1, 3] = "-шт. Стоевые";
                nbox3[2, 0] = w - 32;
                nbox3[2, 1] = 80;
                nbox3[2, 2] = 2;
                nbox3[2, 3] = "-шт. Связь";
                nbox3[3, 0] = 270;
                nbox3[3, 1] = 440;
                nbox3[3, 2] = 2;
                nbox3[3, 3] = "-шт. Деталь ящика 1.1";
                nbox3[4, 0] = 242;
                nbox3[4, 1] = w - 74;
                nbox3[4, 2] =2;
                nbox3[4, 3] = "-шт. Деталь ящика 1.2";
                nbox3[5, 0] = 120;
                nbox3[5, 1] = 440;
                nbox3[5, 2] = 4;
                nbox3[5, 3] = "-шт. Деталь ящика 2.1";
                nbox3[6, 0] = 92;
                nbox3[6, 1] = w - 74;
                nbox3[6, 2] = 4;
                nbox3[6, 3] = "-шт. Деталь ящика 2.2";
                nbox3[7, 0] = 440;
                nbox3[7, 1] = w - 74;
                nbox3[7, 2] = 3;
                nbox3[7, 3] = "-шт. Дно ящика";
                nbox3[8, 0] = h - p - 4;
                nbox3[8, 1] = w - 4;
                nbox3[8, 2] = 1;
                nbox3[8, 3] = "-шт. ДВП";
                nbox3[9, 0] = (h - p) / 2 - 3;
                nbox3[9, 1] = w - 3;
                nbox3[9, 2] = 1;
                nbox3[9, 3] = "-шт. Фасад 1";
                nbox3[10, 0] = ((h - p) / 2) / 2 - 3;
                nbox3[10, 1] = w - 3;
                nbox3[10, 2] = 2;
                nbox3[10, 3] = "-шт. Фасад 2";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль  низа с тремя ящиками (скрытый монтаж). " + w + "mm\n");
                for (int i = 0; i < nbox3.GetLength(0); i++)
                {
                    for (int j = 0; j < nbox3.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", nbox3[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета  однодверного верха
            void Calc7 (int h, int l, int w)  
            {
                v1[0, 0] = w - 32;
                v1[0, 1] = l;
                v1[0, 2] = 2;
                v1[0, 3] = "-шт. Дно/крыша";
                v1[1, 0] = h;
                v1[1, 1] = l;
                v1[1, 2] = 2;
                v1[1, 3] = "-шт. Стоевые";
                v1[2, 0] = w - 32;
                v1[2, 1] = l - 2;
                v1[2, 2] = 2;
                v1[2, 3] = "-шт. Полка";
                v1[3, 0] = h - 4;
                v1[3, 1] = w - 4;
                v1[3, 2] = 1;
                v1[3, 3] = "-шт. ДВП";
                v1[4, 0] = h - 3;
                v1[4, 1] = w - 3;
                v1[4, 2] = 1;
                v1[4, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль однодверного верха. " + w + "mm\n");
                for (int i = 0; i < v1.GetLength(0); i++)
                {
                    for (int j = 0; j < v1.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", v1[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета  двухдверного верха
            void Calc8 (int h, int l, int w)  
            {
                v2[0, 0] = w - 32;
                v2[0, 1] = l;
                v2[0, 2] = 2;
                v2[0, 3] = "-шт. Дно/крыша";
                v2[1, 0] = h;
                v2[1, 1] = l;
                v2[1, 2] = 2;
                v2[1, 3] = "-шт. Стоевые";
                v2[2, 0] = w - 32;
                v2[2, 1] = l - 2;
                v2[2, 2] = 2;
                v2[2, 3] = "-шт. Полка";
                v2[3, 0] = h - 4;
                v2[3, 1] = w - 4;
                v2[3, 2] = 1;
                v2[3, 3] = "-шт. ДВП";
                v2[4, 0] = h - 3;
                v2[4, 1] = w / 2 - 3;
                v2[4, 2] = 2;
                v2[4, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль двухдверного верха. " + w + "mm\n");
                for (int i = 0; i < v2.GetLength(0); i++)
                {
                    for (int j = 0; j < v2.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", v2[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета  верха с горизонтальным открытием фасада
            void Calc9 (int h, int l, int w)   
            {
                vh[0, 0] = w - 32;
                vh[0, 1] = l;
                vh[0, 2] = 2;
                vh[0, 3] = "-шт. Дно/крыша";
                vh[1, 0] = h;
                vh[1, 1] = l;
                vh[1, 2] = 2;
                vh[1, 3] = "-шт. Стоевые";
                vh[2, 0] = w - 32;
                vh[2, 1] = l - 2;
                vh[2, 2] = 1;
                vh[2, 3] = "-шт. Полка";
                vh[3, 0] = h - 4;
                vh[3, 1] = w - 4;
                vh[3, 2] = 1;
                vh[3, 3] = "-шт. ДВП";
                vh[4, 0] = h / 2 - 3;
                vh[4, 1] = w - 3;
                vh[4, 2] = 2;
                vh[4, 3] = "-шт.Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль верха с горизонтальным открытием фасада. " + w + "mm\n");
                for (int i = 0; i < vh.GetLength(0); i++)
                {
                    for (int j = 0; j < vh.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", vh[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }
            // объявление метода для расчета  верха c вытяжкой накладной
            void Calc10 (int h, int l, int w)  
            {
                vv[0, 0] = w - 32;
                vv[0, 1] = l;
                vv[0, 2] = 2;
                vv[0, 3] = "-шт. Дно/крыша";
                vv[1, 0] = h - 40;
                vv[1, 1] = l;
                vv[1, 2] = 2;
                vv[1, 3] = "-шт. Стоевые";
                vv[2, 0] = w - 32;
                vv[2, 1] = l - 2;
                vv[2, 2] = 1;
                vv[2, 3] = "-шт. Полка";
                vv[3, 0] = h - 44;
                vv[3, 1] = w - 4;
                vv[3, 2] = 1;
                vv[3, 3] = "-шт. ДВП";
                vv[4, 0] = h - 43;
                vv[4, 1] = w - 3;
                vv[4, 2] = 1;
                vv[4, 3] = "-шт. Фасад";
                StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine("Модуль верха c вытяжкой накладной. " + w + "mm\n");
                for (int i = 0; i < vv.GetLength(0); i++)
                {
                    for (int j = 0; j < vv.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", vv[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
            }

        }
    }
}

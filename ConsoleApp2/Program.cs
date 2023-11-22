using ConsoleApp2;
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
    public class Program
    {
        static void Main(string[] args)
        {

            void AddToPrint(string InPutName, int InPutWidth, object[,] InPutMas)         // Метод записи данных в текстовый документ (дополняет файл без удаления информации)
            {

               using StreamWriter sw = new StreamWriter("D:\\Report.txt", true, Encoding.UTF8);
                sw.WriteLine(InPutName + " шириной " + InPutWidth + "(mm).\n");
                for (int i = 0; i < InPutMas.GetLength(0); i++)
                {
                    for (int j = 0; j < InPutMas.GetLength(1); j++)
                    {
                        sw.Write("{0,5}\t", InPutMas[i, j] + " ");
                    }
                    sw.Write("\n");
                }
                sw.Write('\n');
                sw.Close();
              
            }



            using StreamWriter sw1 = new StreamWriter("D:\\Report.txt", false, Encoding.UTF8);    
            sw1.Write(string.Empty);                                                        //очищает текстовый файл, закрывает поток
            sw1.Close();                                                                    
           
            try
            {


                Console.WriteLine("Введите высоту низа кухни (мм)");
                var height = Convert.ToInt32(Console.ReadLine());  //Ввод переменной height с проверкой на корректность данных
                if (height < 100 || height > 1000)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод высоты");
                    height = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите глубину модулей кухни (мм)");     //Ввод переменной depth с проверкой на корректность данных
                var depth = Convert.ToInt32(Console.ReadLine());
                if (depth < 100 || depth > 1000)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод глубины");
                    depth = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите высоту цоколя кухни (мм)");        //Ввод переменной plinth с проверкой на корректность данных
                var plinth = Convert.ToInt32(Console.ReadLine());
                if (plinth > 250 || depth < 20)
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
                    int enteredValue = Convert.ToInt32(Console.ReadLine());  // введеное значение пользователем

                    switch (enteredValue)
                    {


                        case 1:
                            Console.WriteLine("Введите ширину модуля:");
                            var width = Convert.ToInt32(Console.ReadLine());
                            if (width < 100 || width > 1500)
                            {
                                Console.WriteLine("Вы ввели некорректное значение. Повторите ввод ");
                                width = Convert.ToInt32(Console.ReadLine());
                            }

                            CargoModul cargo = new CargoModul();
                            cargo.height = height;
                            cargo.width = width;
                            cargo.plinth = plinth;
                            cargo.depth = depth;
                            cargo.calculation();
                            AddToPrint(cargo.name, cargo.width, cargo.array);
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
                            OvenModul oven = new OvenModul();
                            oven.height = height;
                            oven.width = width2;
                            oven.plinth = plinth;
                            oven.depth = depth;
                            oven.calculation();
                            AddToPrint(oven.name, oven.width, oven.array);
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
                            SingleDoorModul singleDoor = new SingleDoorModul();
                            singleDoor.height = height;
                            singleDoor.width = width3;
                            singleDoor.plinth = plinth;
                            singleDoor.depth = depth;
                            singleDoor.calculation();
                            AddToPrint(singleDoor.name, singleDoor.width, singleDoor.array);
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

                            TwoDoorModul twoDoor = new TwoDoorModul();
                            twoDoor.height = height;
                            twoDoor.width = width4;
                            twoDoor.plinth = plinth;
                            twoDoor.depth = depth;
                            twoDoor.calculation();
                            AddToPrint(twoDoor.name, twoDoor.width, twoDoor.array);
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
                            TwoBoxModul twoBox = new TwoBoxModul();
                            twoBox.height = height;
                            twoBox.width = width5;
                            twoBox.plinth = plinth;
                            twoBox.depth = depth;
                            twoBox.calculation();
                            AddToPrint(twoBox.name, twoBox.width, twoBox.array);
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
                            ThreeBoxModul threeBox = new ThreeBoxModul();
                            threeBox.height = height;
                            threeBox.width = width6;
                            threeBox.plinth = plinth;
                            threeBox.depth = depth;
                            threeBox.calculation();
                            AddToPrint(threeBox.name, threeBox.width, threeBox.array);
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
                var heightTop = Convert.ToInt32(Console.ReadLine());
                if (heightTop < 100 || heightTop > 1300)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод");
                    heightTop = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Введите глубину верха кухни (мм)");
                var depthTop = Convert.ToInt32(Console.ReadLine());
                if (depthTop < 10 || depthTop > 800)
                {
                    Console.WriteLine("Вы ввели некорректное значение. Повторите ввод");
                    depthTop = Convert.ToInt32(Console.ReadLine());
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
                            SingleDoorTop singleDoorTop = new SingleDoorTop();
                            singleDoorTop.height = heightTop;
                            singleDoorTop.width = width7;
                            singleDoorTop.depth = depthTop;
                            singleDoorTop.calculation();
                            AddToPrint(singleDoorTop.name, singleDoorTop.width, singleDoorTop.array);
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
                            TwoDoorTop twoDoorTop = new TwoDoorTop();
                            twoDoorTop.height = heightTop;
                            twoDoorTop.width = width8;
                            twoDoorTop.depth = depthTop;
                            twoDoorTop.calculation();
                            AddToPrint(twoDoorTop.name, twoDoorTop.width, twoDoorTop.array);
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
                            HorizontalDoorsTop horizontalDoorsTop = new HorizontalDoorsTop();
                            horizontalDoorsTop.height = heightTop;
                            horizontalDoorsTop.width = width9;
                            horizontalDoorsTop.depth = depthTop;
                            horizontalDoorsTop.calculation();
                            AddToPrint(horizontalDoorsTop.name, horizontalDoorsTop.width, horizontalDoorsTop.array);
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
                            HoodModul hoodModul = new HoodModul();
                            hoodModul.height = heightTop;
                            hoodModul.width = width10;
                            hoodModul.depth = depthTop;
                            hoodModul.calculation();
                            AddToPrint(hoodModul.name, hoodModul.width, hoodModul.array);
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

            //Открытие результата вычислений в формате .txt

            using  System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = @"D:\Report.txt";
            txt.Start();
            Environment.Exit(0);

        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class OvenModul
    {
        public string name = "Модуль духового ящика";
        public int height;          //высота низа кухни
        public int depth;           //глубина модуля
        public int plinth;          //цоколь(высота)
        public int width;           //ширина
        public object[,] array = new object[7, 4]; //массив для вывода деталей
        public object[,] calculation()
        {

            array[0, 0] = width;
            array[0, 1] = depth;
            array[0, 2] = 1;
            array[0, 3] = "-шт. Дно";
            array[1, 0] = height - plinth - 16;
            array[1, 1] = depth;
            array[1, 2] = 2;
            array[1, 3] = "-шт. Стоевые";
            array[2, 0] = width - 32;
            array[2, 1] = depth;
            array[2, 2] = 1;
            array[2, 3] = "-шт. Полка";
            array[3, 0] = height - plinth - 660;
            array[3, 1] = 450;
            array[3, 2] = 2;
            array[3, 3] = "-шт. Деталь ящика 1.1";
            array[4, 0] = height - plinth - 660;
            array[4, 1] = width - 91;
            array[4, 2] = 2;
            array[4, 3] = "-шт. Деталь ящика 1.2";
            array[5, 0] = 446;
            array[5, 1] = width - 63;
            array[5, 2] = 1;
            array[5, 3] = "-шт. ДВП";
            array[6, 0] = height - plinth - 603;
            array[6, 1] = width - 3;
            array[6, 2] = 1;
            array[6, 3] = "-шт. Фасад";
            return array;

        }
    }
}

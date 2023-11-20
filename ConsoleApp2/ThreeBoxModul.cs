using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ThreeBoxModul
    {
        public string name = "Модуль на три ящика";
        public int height;          //высота низа кухни
        public int depth;           //глубина модуля
        public int plinth;          //цоколь(высота)
        public int width;           //ширина
        public object[,] array = new object[11, 4]; //массив для вывода деталей
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
            array[2, 1] = 80;
            array[2, 2] = 2;
            array[2, 3] = "-шт. Связь";
            array[3, 0] = 270;
            array[3, 1] = 440;
            array[3, 2] = 2;
            array[3, 3] = "-шт. Деталь ящика 1.1";
            array[4, 0] = 242;
            array[4, 1] = width - 74;
            array[4, 2] = 2;
            array[4, 3] = "-шт. Деталь ящика 1.2";
            array[5, 0] = 120;
            array[5, 1] = 440;
            array[5, 2] = 4;
            array[5, 3] = "-шт. Деталь ящика 2.1";
            array[6, 0] = 92;
            array[6, 1] = width - 74;
            array[6, 2] = 4;
            array[6, 3] = "-шт. Деталь ящика 2.2";
            array[7, 0] = 440;
            array[7, 1] = width - 74;
            array[7, 2] = 3;
            array[7, 3] = "-шт. Дно ящика";
            array[8, 0] = height - plinth - 4;
            array[8, 1] = width - 4;
            array[8, 2] = 1;
            array[8, 3] = "-шт. ДВП";
            array[9, 0] = (height - plinth) / 2 - 3;
            array[9, 1] = width - 3;
            array[9, 2] = 1;
            array[9, 3] = "-шт. Фасад 1";
            array[10, 0] = ((height - plinth) / 2) / 2 - 3;
            array[10, 1] = width - 3;
            array[10, 2] = 2;
            array[10, 3] = "-шт. Фасад 2";
            return array;
        }
    }
}

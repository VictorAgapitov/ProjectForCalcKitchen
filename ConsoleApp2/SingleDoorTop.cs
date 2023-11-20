using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SingleDoorTop
    {
        public string name = "Однодверный верхний модуль";
        public int height;          //высота верха кухни
        public int depth;           //глубина верха кухни
        public int width;           //ширина
        public object[,] array = new object[5, 4]; //массив для вывода деталей
        public object[,] calculation()
        {
            array[0, 0] = width - 32;
            array[0, 1] = depth;
            array[0, 2] = 2;
            array[0, 3] = "-шт. Дно/крыша";
            array[1, 0] = height;
            array[1, 1] = depth;
            array[1, 2] = 2;
            array[1, 3] = "-шт. Стоевые";
            array[2, 0] = width - 32;
            array[2, 1] = depth - 2;
            array[2, 2] = 2;
            array[2, 3] = "-шт. Полка";
            array[3, 0] = height - 4;
            array[3, 1] = width - 4;
            array[3, 2] = 1;
            array[3, 3] = "-шт. ДВП";
            array[4, 0] = height - 3;
            array[4, 1] = width - 3;
            array[4, 2] = 1;
            array[4, 3] = "-шт. Фасад";
            return array;
        }
    }
}

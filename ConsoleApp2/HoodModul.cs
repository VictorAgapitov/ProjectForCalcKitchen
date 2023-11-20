using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HoodModul
    {
        public string name = "Модуль верха под вытяжку";
        public int height;          //высота верха кухни
        public int depth;           //глубина верха кухни
        public int width;           //ширина
        public object[,] arrey = new object[5, 4]; //массив для вывода деталей
        public object[,] calculation()
        {
            arrey[0, 0] = width - 32;
            arrey[0, 1] = depth;
            arrey[0, 2] = 2;
            arrey[0, 3] = "-шт. Дно/крыша";
            arrey[1, 0] = height - 40;
            arrey[1, 1] = depth;
            arrey[1, 2] = 2;
            arrey[1, 3] = "-шт. Стоевые";
            arrey[2, 0] = width - 32;
            arrey[2, 1] = depth - 2;
            arrey[2, 2] = 1;
            arrey[2, 3] = "-шт. Полка";
            arrey[3, 0] = height - 44;
            arrey[3, 1] = width - 4;
            arrey[3, 2] = 1;
            arrey[3, 3] = "-шт. ДВП";
            arrey[4, 0] = height - 43;
            arrey[4, 1] = width - 3;
            arrey[4, 2] = 1;
            arrey[4, 3] = "-шт. Фасад";
            return arrey; 
        }
    }
}

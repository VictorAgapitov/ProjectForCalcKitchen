using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CargoModul
    {
       public string name = "Модуль карго";
       public int height;          //высота низа кухни
       public int depth;           //глубина модуля
       public int plinth;          //цоколь(высота)
       public int width;           //ширина
       public object[,] arrey = new object[5, 4]; //массив для вывода деталей
        public object[,] calculation()   
        {
         
            arrey[0, 0] = width;
            arrey[0, 1] = depth;
            arrey[0, 2] = 1;
            arrey[0, 3] = "-шт. Дно";
            arrey[1, 0] = height - plinth - 16;
            arrey[1, 1] = depth;
            arrey[1, 2] = 2;
            arrey[1, 3] = "-шт. Стоевые";
            arrey[2, 0] = width - 32;
            arrey[2, 1] = 80;
            arrey[2, 2] = 2;
            arrey[2, 3] = "-шт. Связь";
            arrey[3, 0] = height - plinth - 4;
            arrey[3, 1] = width - 4;
            arrey[3, 2] = 1;
            arrey[3, 3] = "-шт. ДВП";
            arrey[4, 0] = height - plinth - 3;
            arrey[4, 1] = width - 3;
            arrey[4, 2] = 1;
            arrey[4, 3] = "-шт. Фасад";
            return arrey;

        }      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_entity_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var contex = new bdIlinEntities();
            var stud = contex.Студенты.ToList();
            foreach (var rec in stud)
            {
                Console.WriteLine($"  {rec.ФИО}  группа:{rec.Группа}  курс:{rec.Курс}  дата рождения:{Convert.ToDateTime(rec.Дата_рождения).ToString("dd.MM.yyyy")}");

                foreach (var mr in rec.Оценки)
                {
                    Console.WriteLine($"  {rec.Код_студента} Предмет:{mr.Предметы.Наименование_предмета}  Оценка:{mr.Оценка}");
                }
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}

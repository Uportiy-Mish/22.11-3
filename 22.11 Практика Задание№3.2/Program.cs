using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _22._11_Практика_Задание_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите день недели",
                "Ввод дня недели");
            string name2;
            name2 = Interaction.InputBox("Введите номер дня недели",
                "Ввод номера недели");
            string name3;
            name3 = Interaction.InputBox("Введите дату",
                "Ввод даты");
            string txt = "День недели: " + name1 + ", Номер дня недели: " + name2 + ", Дата: " + name3;
            MessageBox.Show(txt, "Итог.");
        }
    }
}

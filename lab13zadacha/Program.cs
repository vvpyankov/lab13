using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задан класс Building, который описывает здание. Класс содержит следующие элементы:

адрес здания;
длина здания;
ширина здания;
высота здания.
В классе Building нужно реализовать следующие методы:

конструктор с 4 параметрами;
свойства get/set для доступа к полям класса;
метод Print(), который выводит информацию о здании.
Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

конструктор с 5 параметрами – реализует вызов конструктора базового класса;
свойство get/set доступа к внутреннему полю класса;
метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
Класс MultiBuilding сделать таким, что не может быть унаследован.*/

namespace lab13zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Building building = new Building("Университетский пр-т, дом 3", 40, 30, 20);
            building.Print();
            MultiBuilding multiBuilding = new MultiBuilding("Университетский пр-т, дом 3", 40, 30, 20, 5);
            multiBuilding.Print();
        }

    }
    public class Building //Задан класс Building, который описывает здание. Класс содержит след эл-ты:адр; дл; шир; выс

    {
        protected string adress;
        protected int length;
        protected int wide;
        protected int heigh;

        public Building(string Adress, int length, int wide, int heigh) // метод Print(), который выводит информацию о здании.
        {
            this.Adress = Adress;
            this.length = length;
            this.wide = wide;
            this.heigh = heigh;
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Wide
        {
            get { return wide; }
            set { wide = value; }
        }
        public int Heigh
        {
            get { return heigh; }
            set { heigh = value; }
        }
        public void Print(/*string adress, int length, int wide, int heigh*/)
        {
            Console.WriteLine("Адрес здания {0}, длина {1} м, ширина {2} м,высота {3} м.", adress, length, wide, heigh);
            Console.ReadKey();
        }


    }
    sealed class MultiBuilding : Building //дочерний класс
    {
        protected int floor { get; set; }
        public MultiBuilding(string adress, int length, int wide, int heigh, int floor)
                        : base(adress, length, wide, heigh)
        {
            base.Adress = Adress;
            this.length = length;
            this.wide = wide;
            this.heigh = heigh;
            this.Floor = floor;
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей:{0}", floor);
            Console.ReadKey();
        }
    }
}




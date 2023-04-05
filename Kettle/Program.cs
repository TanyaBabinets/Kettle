using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 6.2
//Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». 
// С помощью конструктора установить имя каждого устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//■ Sound — издает звук устройства (пишем текстом в консоль);
//■ Show — отображает название устройства;
//■ Desc — отображает описание устройства.
namespace Kettle
{
    
      abstract class Device
        {
            protected string name;
            protected float power;
        abstract public void Sound();
         abstract public void Show();
           abstract public void Descript();

        };
        class Kettle : Device
        {
            public Kettle(string n, float p)
            {
                name = n;
                power = p;

            }
            public override void Show()
            {
                Console.WriteLine($"Kettle {name}");
            }
        public override void  Descript()
            {
                Console.WriteLine("Electronic device for boiling water");
            }
           public override void Sound()
            {
                Console.WriteLine("Makes whisle sound when boiling ");
            }
        };

            class MicroWave : Device
            {
                public MicroWave(string n, float p)
                {
                    name = n;
                    power = p;

                }
        public override void Show()
                {
                    Console.WriteLine($"MicroWave {name}");
                }
        public override void Descript()
                {
                    Console.WriteLine("Electronic device for cooking food");
                }
        public override void Sound()
                {
                    Console.WriteLine("Makes BEEEEEEP sound when food is ready ");
                }
            };
        class Car : Device
        {
            public Car(string n, float p)
            {
                name = n;
                power = p;

            }
        public override void Show()
            {
                Console.WriteLine($"Car {name} has power { power}");
            }
        public override void Descript()
            {
                Console.WriteLine("it's a vehicle for driving. Needs fuel.");
            }
        public override void Sound()
            {
                Console.WriteLine("Makes ZHHHZHZHH sound while moving ");
            }
        };
        class Vessel : Device
        {
            public Vessel(string n, float p)
            {
                name = n;
                power = p;

            }
        public override void Show()
            {
                Console.WriteLine($"Vessel {name} has power { power}");
            }
        public override void Descript()
            {
                Console.WriteLine("Passenger vessel for tour around the lake.");
            }
        public override void Sound()
            {
                Console.WriteLine("Makes UUUUUU sound before start moving ");
            }
        };
    class Program
    { 


    static void Main(string[] args)
        {
            Kettle kettle=new Kettle("Siemens", 1.5f);
            kettle.Show();
            kettle.Descript();
            kettle.Sound();
            Console.WriteLine();
            MicroWave mc = new MicroWave("Gorenje", 3.5f);
            mc.Show();
            mc.Descript();
            mc.Sound();
            Console.WriteLine();
            Car car = new Car("Mersedes", 24000);
            car.Show();
            car.Descript();
            car.Sound();
            Console.WriteLine();
            Vessel v = new Vessel("Arcadia", 6000000);
            v.Show();
            v.Descript();
            v.Sound();
        }
    }
}

//using System.Threading.Channels;
//using System.IO.IsolatedStorage;
//namespace laba3
//{

//    internal class Program
//    {

//        static void Main(string[] args)
//        {
            

//            var times = Enum.GetValues(typeof(TimeOfDay));
//            var heroes = Enum.GetValues(typeof(Hero));

//            for (int i = 0; i < times.Length; i++)
//            {
//                TimeOfDay time = (TimeOfDay)times.GetValue(i);
//                Console.WriteLine($"\nВремя сейчас: {time}");
//                for (int j = 0; j < heroes.Length; j++)
//                {
//                    Hero h = (Hero)heroes.GetValue(j);
//                    Console.Write($"{h} - ");
//                    switch (time)
//                    {
//                        case TimeOfDay.Утро:
//                            Console.WriteLine(h switch
//                            {
//                                Hero.воин => "делает зараядку с мечом",
//                                Hero.маг => "заваривает зелья",
//                                Hero.вор => "крадется по базару",
//                                _ => "ничего не делает"
//                            });
//                            break;
//                        case TimeOfDay.День:
//                            Console.WriteLine(h switch
//                            {
//                                Hero.воин => "тренируется на арене",
//                                Hero.маг => "изучает древние книги",
//                                Hero.вор => "прячется в тенях",
//                                _ => ""
//                            });
//                            break;
//                        case TimeOfDay.Вечер:
//                            Console.WriteLine(h switch
//                            {
//                                Hero.воин => "ест мясо у костра",
//                                Hero.маг => "создает магический щит",
//                                Hero.вор => "планирует налет",
//                                _ => ""
//                            });
//                            break;
//                        case TimeOfDay.Ночь:
//                            Console.WriteLine(h switch
//                            {
//                                Hero.воин => "спит в палатке",
//                                Hero.маг => "медитирует под луной",
//                                Hero.вор => "лезет в чужой дом",
//                                _ => ""
//                            });
//                            break;
//                    }

//                }
//            }


//            enum Hero { воин, маг, вор }
//            enum TimeOfDay { Утро, День, Вечер, Ночь }
















//        //DayOfWeek today = DayOfWeek.Friday;
//        //Console.WriteLine(today);

//        //TaskPriority priority = TaskPriority.High;
//        //Console.WriteLine((int)priority);
//        //DayOfWeek day = DayOfWeek.Saturday;
//        //switch (day)
//        //{
//        //    case DayOfWeek.Saturday:
//        //    case DayOfWeek.Sunday:
//        //        Console.WriteLine("Выходной! ");
//        //        break;
//        //    default:
//        //        Console.WriteLine("Будний день.");
//        //        break;

//        //}















//        //for (int i = 1; i < 10; i++)
//        //{
//        //    Console.WriteLine(i);
//        //}
//        //int i = 1;
//        //for (; ;)
//        //{
//        //    Console.WriteLine($"i = {i}");
//        //    i++;
//        //}

//        //for (int i = 1, j =1; i < 10;i++, j++)
//        //{
//        //    Console.WriteLine($"{i * j}");
//        //}

//        //int sum = 0;
//        //for (int i = 1; i <= 10; i++)
//        //{
//        //    sum += i;
//        //}
//        //Console.WriteLine($"Сумма: {sum}");

//        //int i = 10;
//        //do
//        //{
//        //    Console.WriteLine(i);
//        //    i--;
//        //}
//        //while (i > 0);
//        //int i = 10;
//        //while (i > 0)
//        //{
//        //    Console.WriteLine(i);
//        //    i--;
//        //}

//        //foreach (char i in "Hello World")
//        //{
//        //    Console.WriteLine(i);
//        //}
//        //for (int i =0; i < 9; i++)
//        //{
//        //    if (i == 5)
//        //        break;
//        //    Console.WriteLine(i);
//        //}

//        //for (int i = 1; i < 10; i++)
//        //{
//        //    for (int j = 1; j < 10; j++)
//        //    {
//        //        Console.WriteLine($"{i * j} \t");

//        //    }
//        //    Console.WriteLine();
//        //}
//        //string? input;
//        //Console.WriteLine("Добро пожаловатьт в Эхо-чат! Напиши что нибудь (или 'выход' для завершения): ");
//        //while (true) {
//        //    Console.WriteLine("> ");
//        //    input = Console.ReadLine();
//        //    if (input == null)
//        //        continue;
//        //    if (input.ToLower() == "выход")
//        //    {
//        //        Console.WriteLine("До встречи!");
//        //        break;
//        //    }
//        //    Console.WriteLine($"Вы сказали: {input}");

//        //}

//        enum DayOfWeek
//        {
//            Monday,
//            Tuesday,
//            Wednesday,
//            Thursday,
//            Friday,
//            Saturday,
//            Sunday
//        }

//        enum TaskPriority
//        {
//            Low = 1,
//            Medium = 2,
//            High = 3
//        }


    
//    }
//}

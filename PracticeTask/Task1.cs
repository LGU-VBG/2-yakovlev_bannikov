// Создайте класс, описывающий сущность "Стрелок".
// Стрелок стреляет в мишень патронами. Набирает очки. Количество патронов 8 штук. Создайте класс "Судья".
// Иногда происходят осечки, возникает событие «Нужен еще патрон». В этом случае судья дает дополнительный патрон.
// Дизайн классов на ваше усмотрение. В консоль вывести результат каждого выстрела и события
// Также попробуйте заменить обычные методы на лямбда-выражения, где это возможно.


namespace Task1;

public delegate void СartridgeNeededEventHandler(object sender);

class Shooting
{
    public class Shooter
    {
        public static event СartridgeNeededEventHandler OnСartridgeNeeded;
        public static int сartridgeCount = 8;
        private int shootNum = 0;
        public int score = 0;

        public void Shoot()
        {
            Random random = new Random();
            bool isHit = random.Next(3) == 0;
            bool isMissFire = random.Next(1, 5) == 1;

            shootNum++;
            сartridgeCount--;

            if (isMissFire)
            {
                Console.WriteLine($"{shootNum} Выстрел: Произошла осечка!");

                OnСartridgeNeeded?.Invoke(this);
            }
            else
            {
                if (isHit)
                {
                    score++;
                    Console.WriteLine($"{shootNum} Выстрел: Попадание! Счёт: {score}");
                }
                else
                {
                    Console.WriteLine($"{shootNum} Выстрел: Промах...");
                }
            }
        }
    }

    public class Judge
    {
        public static void GiveСartridge(object sender)
        {
            Shooter.сartridgeCount++;
            Console.WriteLine("Судья дал еще патрон");
        }
    }

    public static void Initialize()
    {
        Shooter shooter = new Shooter();
        Judge judge = new Judge();

        Shooter.OnСartridgeNeeded += Judge.GiveСartridge;

        while (true)
        {
            shooter.Shoot();

            if (Shooter.сartridgeCount <= 0)
            {
                Console.WriteLine($"Стрельбу закончил, иитоговый счёт: {shooter.score}");
                break;
            }
        }
    }
}

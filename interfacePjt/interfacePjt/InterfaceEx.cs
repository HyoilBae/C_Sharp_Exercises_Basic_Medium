using System;

namespace interfacePjt
{
    class InterfaceEx
    {
        static void Main(string[] args)
        {
            ToyForKR toyForKR = new ToyForKR();
            //toyForKR.Greet();

            Console.WriteLine();

            ToyForUS toyForUS = new ToyForUS();
            //toyForUS.GreetFirst();

            Console.WriteLine();

            ToyForCN toyForCN = new ToyForCN();
            //toyForCN.GreetForFirst();

            // 인터페이스
            toyForKR.DoGreet();
            toyForUS.DoGreet();
            toyForCN.DoGreet();

            IToy[] Toys = { toyForKR, toyForUS, toyForCN };
            for(int i = 0; i < Toys.Length; i++)
            {
                Toys[i].DoGreet();
            }

            Console.WriteLine();

            // 인터페이스 상속
            Robot robot = new Robot();
            robot.DoWalk();
            robot.DoFly();

            IRobot oldRobot = robot as IRobot;
            oldRobot.DoWalk();
            //oldRobot.DoFly();

            INewGenerationRobot newGenerationRobot = robot as INewGenerationRobot;
            newGenerationRobot.DoWalk();
            newGenerationRobot.DoFly();

            Console.WriteLine();

            // 인터페이스 다중 상속
            MySuperCar mySuperCar = new MySuperCar();
            mySuperCar.DoDriving();
            mySuperCar.DoFlight();

            ICar myCar = mySuperCar as ICar;
            myCar.DoDriving();
            // myCar.DoFlight();

            IAirplane myAirplane = mySuperCar as IAirplane;
            //myAirplane.DoDriving();
            myAirplane.DoFlight();
        }
    }
}

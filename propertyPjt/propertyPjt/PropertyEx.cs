using System;

namespace propertyPjt
{
    class PropertyEx
    {
        static void Main(string[] args)
        {
            // Getter / Setter
            Student student1 = new Student("2019-000001", "박찬호", 20, "Baseball");

            Console.WriteLine($"student1.GetId()\t: {student1.GetId()}");
            Console.WriteLine($"student1.GetName()\t: {student1.GetName()}");
            Console.WriteLine($"student1.GetAge()\t: {student1.GetAge()}");
            Console.WriteLine($"student1.GetMajor()\t: {student1.GetMajor()}");

            Student student2 = new Student();
            student2.SetId("2019-000002");
            student2.SetName("손흥민");
            student2.SetAge(21);
            student2.SetMajor("Soccer");

            Console.WriteLine($"student2.GetId()\t: {student2.GetId()}");
            Console.WriteLine($"student2.GetName()\t: {student2.GetName()}");
            Console.WriteLine($"student2.GetAge()\t: {student2.GetAge()}");
            Console.WriteLine($"student2.GetMajor()\t: {student2.GetMajor()}");

            Console.WriteLine();

            // Property
            StudentUseProperty studentUseProperty = new StudentUseProperty();
            studentUseProperty.Id = "2019-000003";
            studentUseProperty.Name = "박태환";
            studentUseProperty.Age = 22;
            studentUseProperty.Major = "Swim";

            Console.WriteLine($"studentUseProperty.Id\t: {studentUseProperty.Id}");
            Console.WriteLine($"studentUseProperty.Name\t: {studentUseProperty.Name}");
            Console.WriteLine($"studentUseProperty.Age\t: {studentUseProperty.Age}");
            Console.WriteLine($"studentUseProperty.Major\t: {studentUseProperty.Major}");

            Console.WriteLine($"studentUseProperty.info\t: {studentUseProperty.Info}");

            Console.WriteLine();

            StudentUseAutoImplementProperty StudentUseAutoImplementProperty = new StudentUseAutoImplementProperty();
            StudentUseAutoImplementProperty.Id = "2019-000004";
            StudentUseAutoImplementProperty.Name = "김광현";
            StudentUseAutoImplementProperty.Age = 23;
            StudentUseAutoImplementProperty.Major = "Baseball";

            Console.WriteLine($"StudentUseAutoImplementProperty.Id\t: {StudentUseAutoImplementProperty.Id}");
            Console.WriteLine($"StudentUseAutoImplementProperty.Name\t: {StudentUseAutoImplementProperty.Name}");
            Console.WriteLine($"StudentUseAutoImplementProperty.Age\t: {StudentUseAutoImplementProperty.Age}");
            Console.WriteLine($"StudentUseAutoImplementProperty.Major\t: {StudentUseAutoImplementProperty.Major}");

            Console.WriteLine();

            StudentUseAutoImplementPropertyReset StudentUseAutoImplementPropertyReset1 = new StudentUseAutoImplementPropertyReset();

            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Id\t: {StudentUseAutoImplementPropertyReset1.Id}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Name\t: {StudentUseAutoImplementPropertyReset1.Name}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Age\t: {StudentUseAutoImplementPropertyReset1.Age}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Major\t: {StudentUseAutoImplementPropertyReset1.Major}");

            StudentUseAutoImplementPropertyReset1.Id = "2019-000005";
            StudentUseAutoImplementPropertyReset1.Name = "김연아";
            StudentUseAutoImplementPropertyReset1.Age = 24;
            StudentUseAutoImplementPropertyReset1.Major = "Skate";

            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Id\t: {StudentUseAutoImplementPropertyReset1.Id}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Name\t: {StudentUseAutoImplementPropertyReset1.Name}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Age\t: {StudentUseAutoImplementPropertyReset1.Age}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset1.Major\t: {StudentUseAutoImplementPropertyReset1.Major}");

            Console.WriteLine();

            StudentUseAutoImplementPropertyReset StudentUseAutoImplementPropertyReset2 = new StudentUseAutoImplementPropertyReset()
            {
                Id = "2019-000006",
                Name = "류현진",
                Age = 25,
                //Major = "Baseball"
            };

            Console.WriteLine($"StudentUseAutoImplementPropertyReset2.Id\t: {StudentUseAutoImplementPropertyReset2.Id}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset2.Name\t: {StudentUseAutoImplementPropertyReset2.Name}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset2.Age\t: {StudentUseAutoImplementPropertyReset2.Age}");
            Console.WriteLine($"StudentUseAutoImplementPropertyReset2.Major\t: {StudentUseAutoImplementPropertyReset2.Major}");

            Console.WriteLine();

            // Property - Interface
            Car car1 = new Car();
            car1.Name = "MyCar";
            car1.Color = "Red";
            //car1.Price = 10000000;

            car1.PrintCarInfo();

            Car car2 = new Car()
            {
                Name = "FriendCar",
                Color = "Yellow",
                Price = 20000000
            };

            car2.PrintCarInfo();

            // Property - Abstract
            ToyRobot toyRobot = new ToyRobot()
            {
                Origin = "KOREA",
                Name = "TAEGWON V"
            };

            toyRobot.DoWalk();
            toyRobot.DoFly();
            toyRobot.PrintInfo();

        }
    }
}

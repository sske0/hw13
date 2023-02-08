namespace hw13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////1
            //var groups = new List<Group>();
            //groups.Add(new Group("group1"));
            //groups.Add(new Group("group2"));
            //groups.Add(new Group("group3"));

            //string groupToAdd = "group4"; ////"group1/2/3" wont be added
            //if (!groups.Any(group => group.Name == groupToAdd))
            //{
            //    groups.Add(new Group(groupToAdd));
            //}

            //foreach (Group group in groups)
            //{
            //    Console.WriteLine(group.Name);
            //}

            //2
            var students = new List<Student>();
            students.Add(new Student("Israfil", "Israfilov", 3032));
            students.Add(new Student("Light", "Yagami", 666));
            students.Add(new Student("L ", "Lawliet", 6666));
             
            //this student wont be added due to its pin and the fact that its name contains "a"
            string nameToAdd = "Sasuke";
            string surnameToAdd = "Uchiha";
            int pinToAdd = 666;

            if (!students.Any(student => student.PIN == pinToAdd))
            {
                students.Add(new Student(nameToAdd, surnameToAdd, pinToAdd));  
            }

            


            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.PIN}");
            }

            int count = students.Count(student => student.Name.Contains("a"));
            Console.WriteLine("""number of names with "a" : """ + count);

        }
    }
}
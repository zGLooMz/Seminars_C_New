namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grad_father = new AdultFamilyMember() { Mother = null, Name = "Alex", Sex = Gender.Male };
            var father = new AdultFamilyMember() { Mother = null, Name = "Папа", Sex = Gender.Male };
            var mother = new AdultFamilyMember() { Mother = null, Father = null, Name = "Мама", Sex = Gender.Female };
            var son = new FamilyMember() { Mother = mother, Father = mother, Name = " Сын", Sex = Gender.Male };
            mother.Children = new FamilyMember[] { son };
            father.Children = new FamilyMember[] { son };



            grad_father.Print();
            Console.ReadLine();
        }
    }
}
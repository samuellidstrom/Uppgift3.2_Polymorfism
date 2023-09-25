namespace Uppgift3._2_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>();

            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new AgeInputError());
            errors.Add(new FirstNameInputError());
            errors.Add(new CarModelInputError());

            foreach (var userError in errors)
            {
                Console.WriteLine(userError.UEMessage());                                
            }
            Console.ReadLine();

        }
    }
}
namespace Uppgift3._2_Polymorfism
{
    internal class AgeInputError : UserError
    {
        internal override string UEMessage()
        {
            return "Your input value for age did not match the critera for what is acceptable. This fired an error!";
        }
    }
}
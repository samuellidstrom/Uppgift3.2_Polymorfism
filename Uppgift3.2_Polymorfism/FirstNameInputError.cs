namespace Uppgift3._2_Polymorfism
{
    internal class FirstNameInputError : UserError
    {
        internal override string UEMessage()
        {
            return "Your input value does not match the critera set up for a first name. This fired an error!";
        }
    }
}
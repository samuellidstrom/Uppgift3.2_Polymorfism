namespace Uppgift3._2_Polymorfism
{
    internal class CarModelInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to input a car model that does not exist. This fired an error!";
        }
    }
}
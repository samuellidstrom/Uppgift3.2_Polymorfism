namespace Uppgift3._2_Polymorfism
{
    internal class TextInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
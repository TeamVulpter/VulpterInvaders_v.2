namespace Game.Exception
{
    using System;

    class InvalidItemTypeException : Exception
    {
        public InvalidItemTypeException(string message)
            :base(message)
        {
            
        }
    }
}

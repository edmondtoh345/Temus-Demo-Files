﻿namespace LayeredAppDemo.Exceptions
{
    public class CustomerAlreadyExistsException : Exception
    {
        public CustomerAlreadyExistsException() { }
        public CustomerAlreadyExistsException(string message) : base(message) { }
    }
}

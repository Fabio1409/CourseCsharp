﻿using System;


namespace TratamentoExcecoes.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {

        }
    }
}

﻿using System;

namespace TecnicalKatarina
{
    public class TecnicalException : Exception
    {
        public TecnicalException() : base("An Error occcured at Tecnical Gangplank")
        {
        }

        public TecnicalException(string errormsg) : base(errormsg)
        {
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretScrambler.ExceptionHandling
{
    //Not used currently
   public class rhCryptoException : Exception
    {
       public string CryptoTool { get; set; }

       public string CryptoUserPresentationMessage { get; set; }        
    }
}

﻿using System;
namespace Bit.Core.Enums
{
    public enum AuthRequestType : byte
    {
        AuthenticateAndUnlock = 0,
        Unlock = 1,
        AdminApproval = 2
    }
}


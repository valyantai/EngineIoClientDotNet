﻿using System.Security.Cryptography.X509Certificates;

namespace Quobject.EngineIoClientDotNet.Parser
{
    public interface IEncodeCallback
    {
        void Call(object data);
    }

}
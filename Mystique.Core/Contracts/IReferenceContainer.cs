﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mystique.Core.Contracts
{
    public interface IReferenceContainer
    {
        bool Exist(string name, string version);

        void SaveStream(string name, string version, Stream stream);

        Stream GetStream(string name, string version);
    }
}
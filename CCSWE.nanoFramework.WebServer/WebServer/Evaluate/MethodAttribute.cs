﻿//
// Copyright (c) 2020 Laurent Ellerbach and the project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace CCSWE.nanoFramework.WebServer.Evaluate
{
    /// <summary>
    /// The HTTP Method
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [Obsolete("Replace with HttpMethodAttribute")]
    public class MethodAttribute : Attribute
    {
        public string Method { get; set; }

        public MethodAttribute(string method)
        {
            Method = method;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPatterns.Core.Helpers
{
    public static class Type
    {
        public const string VOID = "void";
        public const string INT = "int";
        public const string DOUBLE = "double";
        public const string FLOAT = "float";
        public const string BYTE = "byte";
        public const string CHAR = "char";
        public const string LONG = "long";
        public const string BOOL = "bool";
        public const string STRING = "string";

        public static string[] GetTypes()
        {
            return new[] { VOID, INT, DOUBLE, FLOAT, BYTE, CHAR, LONG, BOOL, STRING };
        }
    }
}

﻿using System;

namespace Reflection.Utils.PropertyTree {
    public enum PropertyValueType {
        Undefined = 0,
        Primitive = 0x1,
        Enum = 0x2,
        Struct = 0x4,
        Nullable = 0x8,
        String = 0x10,
        Exception = 0x20,
        Class = 0x30,
        Interface = 0x40,
        Array = 0x80,
        Enumerable = 0x100
    }
}
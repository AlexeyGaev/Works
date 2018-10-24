﻿using Microsoft.AspNetCore.Http;
using System;

namespace Translation.EngRus.Logger {
    public class ConsoleLogger : ILogger<string> {
        public void Log(string text) {
            Console.WriteLine(text);
        }
    }
}
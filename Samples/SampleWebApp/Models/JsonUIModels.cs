﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class JsonData
    {
        public JsonData()
        {
            payload = null;
            message = string.Empty;
            total = 0;
        }

        public object payload;
        public string message;
        public int total;
        public string errors;
    }
}
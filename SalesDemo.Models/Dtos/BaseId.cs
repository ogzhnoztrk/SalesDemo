﻿using System;

namespace SalesDemo.Models.Dtos
{
    public class BaseIdDto

    {
        public int TimeStamp { get; set; }
        public int Machine { get; set; }
        public int Increment { get; set; }
        public int Pid { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Person
    {
        public int sno { get; set; }
        public string name { get; set; }

        public string city { get; set; }
    }
}

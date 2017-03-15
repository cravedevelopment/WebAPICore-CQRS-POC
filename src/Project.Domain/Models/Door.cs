using System;
using System.Collections.Generic;
using System.Text;
using Project.Domain.Core.Models;

namespace Project.Domain.Models
{
    public class Door : Entity
    {
        public Door(Guid id, string status)
        {
            Id = id;
            Status = status;
        }

        // Empty constructor for EF
        protected Door() { }
        public string Status { get; private set; }

    }
}

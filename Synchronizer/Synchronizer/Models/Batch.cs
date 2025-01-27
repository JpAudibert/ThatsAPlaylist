﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronizer.Models
{
    public class Batch<T>
    {
        public int Id { get; set; }
        public bool Executed { get; set; }
        public LinkedList<Item<T>> Items { get; set; }

        public Batch(int id, LinkedList<Item<T>> items)
        {
            Id = id;
            Executed = false;
            Items = items;
        }

        public Batch(int id)
        {
            Id = id;
            Executed = false;
            Items = new LinkedList<Item<T>>();
        }
    }
}

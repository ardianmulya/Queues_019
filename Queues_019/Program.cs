﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_019
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Queues()
        {
            FRONT = 0;
            REAR = 0;
        }
        public void insert (int element)
        {
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\n Queue overflow\n");
                return;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

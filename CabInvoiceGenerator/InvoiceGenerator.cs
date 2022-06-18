﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private readonly double MINIMUM_COST_PER_KM = 10;
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        public double distance;
        public int time;
        public InvoiceGenerator(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
        public double TotalFare()
        {
            double totalFare = 0;
            if (distance >= 0 && time >= 0)
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_MINUTE;
            }
            else
            {
                if (distance <= 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (time < 0)
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_TIME, "Invalid Time");
                }
            }
            return totalFare;
        }


    }
}


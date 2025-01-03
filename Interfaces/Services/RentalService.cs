﻿using ExercicioComInterface.Services;
using ExercicioComInterface.Entities;

namespace ExercicioComInterface.Services
{
     class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        private ITaxService _taxService;
        
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessingInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);// Math.Ceilling Faz arredondamento pra cima.
            }
            else 
            {
               basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _291CarRental
{
    public class CarModels
    {

        /* CarModel Class created by Alex Creencia
         * Created on April 3, 2020
         * 
         * NOTE: because my string arrays follow the same format, I will only describe one as they all follow the same convention
         * 
         * VARIABLE                                 DESCRIPTION
         * maker                                    a string passed to this class that holds the name of the vehicle maker
         * carFrame                                 a string passed to this class that holds the frame of the vehicle (sedan, suv. etc)
         * ford[carFrame]                           an array holding all models associated with ford with that specific car frame
         * honda[carFrame]                          an array holding all models associated with honda with that specific car frame
         * .
         * .
         * .
         * values                                   an array that holds a copy of whatever the correct models was selected, that is returned to caller through function returnValue()
         * 
         */
        private string maker;
        private string carFrame;
        private string[] values;
        // ford models
        private string[] fordSUV = new string[] { "ecosport", "puma", "escape kuga", "edge", "bronco", "mustang Mach-E", "explorer", "expedition" };
        private string[] fordSedan = new string[] { "consul", "corsair", "cortina", "escort", "fairlane", "fairmont", "falcon", "fiesta", "focus", "galaxie", "laser", "ltd", "meteor", "taurus" };
        private string[] fordCoupe = new string[] { "mustang", "anglia", "capri", "cobra", "cortina", "cougar", "escort", "fairmont", "probe" };
        private string[] fordHatch = new string[] { "fiesta", "mondeo", "ka", "laser", "festiva" };
        private string[] fordTruck = new string[] { "courier", "f-100", "f-150", "f-250", "f-350", "falcon", "maverick", "ranger" };

        // Porsche (only convertible) models
        private string[] porscheConvertible = new string[] { "911", "boxster" };

        // Honda models (suv and sedans)
        private string[] hondaSUV = new string[] { "passport", "pilot"};
        private string[] hondaSedan = new string[] { "civic", "insight", "accord", "accord"};

        // toyota models (suv and sedans)
        private string[] toyotaSedan = new string[] {"crown standard", "crown rs", "camry", "allion"};
        private string[] toyotaSUV = new string[] { "harrier", "fj cruiser", "land cruiser", "hilux" };

        public CarModels(string make, string frame)
        {
            maker = make;
            carFrame = frame;

        }

        public void setModel()
        {
            /*
             * Fills the values with the correct models by using switch checks
             */
            switch (maker)
            {
                case "Ford":
                    switch (carFrame)
                    {
                        case ("suv"):
                            values = fordSUV;
                            break;
                        case ("sedan"):
                            values = fordSedan;
                            break;
                        case ("coupe"):
                            values = fordCoupe;
                            break;
                        case ("hatchback"):
                            values = fordHatch;
                            break;
                        case ("truck"):
                            values = fordTruck;
                            break;

                    }
                    break;
                case "Toyota":
                    switch (carFrame)
                    {
                        case ("sedan"):
                            values = toyotaSedan;
                            break;
                        case ("suv"):
                            values = toyotaSUV;
                            break;
                    }
                    break;
                case "Honda":
                    switch (carFrame)
                    {
                        case ("suv"):
                            values = hondaSUV;
                            break;
                        case ("sedan"):
                            values = hondaSedan;
                            break;
    
                    }
                    break;
                case "Porsche":
                    values = porscheConvertible;
                    break;
             
            }
            
        }
        public string[] returnValues()
        {
            /*
             * calls set model to populate the values array properly, then returns the populated array
             */
            setModel();
            return values;
        }
        public string[] getFordSuv()
        {
            return fordSUV;
        }
        public string[] getFordSedan()
        {
            return fordSedan;
        }
        public string[] getFordCoupe()
        {
            return fordCoupe;
        }
        public string[] getFordHatch()
        {
            return fordSUV;
        }
    }
}

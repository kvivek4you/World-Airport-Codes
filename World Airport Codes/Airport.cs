﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Airport_Codes
{
    class Airport
    {
        private string _AirportName;

        public string AirportName
        {
            get { return _AirportName; }
            set { _AirportName = value; }
        }
        private string _Country;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        private string _IATA;

        public string IATA
        {
            get { return _IATA; }
            set { _IATA = value; }
        }
        private string _ICAO;

        public string ICAO
        {
            get { return _ICAO; }
            set { _ICAO = value; }
        }
        private string _FAA;

        public string FAA
        {
            get { return _FAA; }
            set { _FAA = value; }
        }
        private string _Latitude;

        public string Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }
        private string _Longitude;

        public string Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }


    }
}

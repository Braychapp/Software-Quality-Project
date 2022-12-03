/*
* FILE              : Carrier.cs
* PROJECT           : SoftwareQualityTMS
* PROGRAMMER        : Evan O'Hara
* FIRST VERSION     : 2022-12-03
*                   :
* DESCRIPTION       : Carrier object.
*                   : 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQualityTMS
{
    public class Carrier
    {
        public string CName { get; set; }
        public string CCity { get; set; }
        public int FTLA { get; set; }
        public int LTLA { get; set; }
        public decimal FTLRate { get; set; }
        public decimal LTLRate { get; set; }
        public decimal ReefCharge { get; set; }


        /*  -- Method Header Comment -- CONSTRUCTOR
        Name	 :	Carrier
        Purpose  :	Instantiate a new Carrier object
                 :  
        Inputs	 :	string cName, string cCity, int fTLA, int lTLA, decimal fTLRate, decimal lTLRate, decimal reefCharge
        Outputs	 :	NONE
        Returns  :	NONE
        */
        public Carrier (string cName, string cCity, int fTLA, int lTLA, decimal fTLRate, decimal lTLRate, decimal reefCharge)
        {
            CName = cName;
            CCity = cCity;
            FTLA = fTLA;
            LTLA = lTLA;
            FTLRate = fTLRate;
            LTLRate = lTLRate;
            ReefCharge = reefCharge;
        }



    }
}

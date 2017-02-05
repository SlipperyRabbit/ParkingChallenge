using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParkingChallengeLibrary;
using ParkingChallengeAPI.Models;

namespace ParkingChallengeAPI.Controllers
{
	/// <summary>
	/// Parking Fee Controller
	/// </summary>
    public class ParkingFeeController : ApiController
    {
		public ParkingFeeType Get(string ticket)
		{
			ParkingFeeType feeType = new ParkingFeeType();
			ParkingChallengeUtilities utilities = new ParkingChallengeUtilities();

			feeType.ParkingFeeValue = utilities.GetParkingFees(ticket);

			return feeType;
		}
	}
}

using ParkingChallengeAPI.Models;
using ParkingChallengeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingChallengeAPI.Controllers
{
	/// <summary>
	/// Parking Availability Controller
	/// </summary>
    public class ParkingAvailabilityController : ApiController
    {
		/// <summary>
		/// Get Parking Availability
		/// </summary>
		/// <returns>If parking is available true, otherwise false</returns>
		public ParkingAvailableType Get(string lot)
		{
			ParkingAvailableType availableType = new ParkingAvailableType();
			ParkingChallengeUtilities utilities = new ParkingChallengeUtilities();

			availableType.ParkingAvailableValue = utilities.GetParkingAvailability(lot);

			return availableType;
		}
	}
}

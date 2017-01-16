using ParkingChallengeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ParkingChallenge
{
	/// <summary>
	/// Parking Challenge Services
	/// </summary>
	public class ParkingService : IParkingService
	{
		/// <summary>
		/// Get Parking Available
		/// </summary>
		/// <param name="lot">The parking lot to find available parking spaces</param>
		/// <returns>Returns a Parking Available Type (True/False)</returns>
		public ParkingAvailableType GetParkingAvailability(string lot)
		{
			ParkingAvailableType availableType = new ParkingAvailableType();
			ParkingChallengeUtilities utilities = new ParkingChallengeUtilities();

			availableType.ParkingAvailableValue = utilities.GetParkingAvailability(lot);

			return availableType;
		}

		/// <summary>
		/// Get the parking fee for a given ticket
		/// </summary>
		/// <param name="ticket">A parking ticket identifier</param>
		/// <returns>A Parking Fee Type (decimal money value)</returns>		
		public ParkingFeeType GetParkingFee(long ticket)
		{
			ParkingFeeType feeType = new ParkingFeeType();
			ParkingChallengeUtilities utilities = new ParkingChallengeUtilities();

			feeType.ParkingFeeValue = utilities.GetParkingFees(ticket);

			return feeType;
		}

		public bool GetParkingTest()
		{
			return true;
		}
	}
}

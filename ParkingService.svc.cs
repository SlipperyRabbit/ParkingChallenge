using ParkingChallengeLibrary;
using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ParkingChallenge
{
	/// <summary>
	/// Parking Challenge Services
	/// </summary>
	[AspNetCompatibilityRequirements( RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[SwaggerWcf("/ParkingChallenge/ParkingService.svc")]
	public class ParkingService : IParkingService
	{
		/// <summary>
		/// Get Parking Available
		/// </summary>
		/// <param name="lot">The parking lot to find available parking spaces</param>
		/// <returns>Returns a Parking Available Type (True/False)</returns>
		[SwaggerWcfTag("GetParkingAvailability")]
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
		[SwaggerWcfTag("GetParkingFees")]
		public ParkingFeeType GetParkingFee(string ticket)
		{
			ParkingFeeType feeType = new ParkingFeeType();
			ParkingChallengeUtilities utilities = new ParkingChallengeUtilities();

			feeType.ParkingFeeValue = utilities.GetParkingFees(ticket);

			return feeType;
		}

		/// <summary>
		/// Test routine
		/// </summary>
		/// <returns>True</returns>
		[SwaggerWcfTag("GetParkingTest")]
		public bool GetParkingTest()
		{
			return true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingChallengeAPI.Models
{
	/// <summary>
	/// Parking Fee Type model
	/// </summary>
	public class ParkingFeeType
	{
		/// <summary>
		/// Private Parking Fee variable
		/// </summary>
		decimal parkingFee = 0.0m;

		/// <summary>
		/// Public Parking Fee value
		/// </summary>
		public decimal ParkingFeeValue
		{
			get { return parkingFee; }
			set { parkingFee = value; }
		}
	}
}
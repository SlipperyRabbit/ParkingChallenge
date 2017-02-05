using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChallengeAPI.Models
{
	/// <summary>
	/// Parking Available Type model
	/// </summary>
	public class ParkingAvailableType
	{
		/// <summary>
		/// private parking available variable
		/// </summary>
		bool parkingAvailable = true;

		/// <summary>
		/// Public parking available value
		/// </summary>
		public bool ParkingAvailableValue
		{
			get { return parkingAvailable; }
			set { parkingAvailable = value; }
		}
	}
}

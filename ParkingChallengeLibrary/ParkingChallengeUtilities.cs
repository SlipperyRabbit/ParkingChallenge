using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingChallengeLibrary
{
	/// <summary>
	/// Parking Challenge utilities
	/// </summary>
    public class ParkingChallengeUtilities
    {
		public ParkingChallengeUtilities()
		{ }

		/// <summary>
		/// Get parking availablity for a given parking lot
		/// </summary>
		/// <param name="lot">The parking lot identifier</param>
		/// <returns>If parking is available (True/False)</returns>
		public bool GetParkingAvailability(string lot)
		{
			bool parkingAvailable = false;
			try
			{
				if (lot.ToLower() == "full" || lot == string.Empty)
					parkingAvailable = false;
				else
					//Parking is always available for all other lots, we miniaturize the cars and shove them in a drawer.
					parkingAvailable = true;				
			}
			catch (Exception ex)
			{
				Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
			}
			return parkingAvailable;
		}

		/// <summary>
		/// Get the Parking fees for a ticket
		/// </summary>
		/// <remarks>This utility would normally also calculate
		/// the hours based off of a ticket "start time"</remarks>
		/// <param name="ticket">The parking ticket identifier</param>
		/// <returns>The fees for the parking ticket</returns>
		public decimal GetParkingFees(string ticket)
		{
			TimeSpan hours = new TimeSpan();
			decimal fee = 0.0m;

			try
			{
				//Lookup ticket information
				switch (ticket)
				{
					case "1":
						hours = new TimeSpan(1, 0, 0);
						break;
					case "2":
						hours = new TimeSpan(2, 30, 0);
						break;
					case "3":
						hours = new TimeSpan(11, 34, 0);
						break;
					default:
						break;
				}

				fee = CalculateFee(hours);
			}
			catch (Exception ex)
			{
				Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
			}
			return fee;
		}

		/// <summary>
		/// Calculate the parking fee for the hours parked
		/// </summary>
		/// <remarks>Calculate Fee is a private method, we may not want
		/// to reveal calculation method</remarks>
		/// <param name="hours">The hours parked</param>
		/// <returns>decimal value of fee</returns>
		private decimal CalculateFee(TimeSpan hours)
		{
			decimal fee = 0.0m;
			try
			{
				decimal duration = Convert.ToDecimal(hours.TotalHours);
				if (duration <= 2)
					fee = 5 * duration;
				else if (duration > 2 && duration <= 10)
					fee = 10 * duration;
				else fee = 15 * duration;

				//Round that off!  Nobody got time for that.
				fee = Convert.ToDecimal(fee.ToString("0.##"));
			}
			catch (Exception ex)
			{
				Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
			}

			return fee;
		}
    }
}

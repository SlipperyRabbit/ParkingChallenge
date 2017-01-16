using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingChallengeLibrary;

namespace ParkingChallenge.Test
{
	[TestClass]
	public class ParkingUtilitiesTest
	{
		[TestMethod]
		public void TestParkingAvailability()
		{
			var target = new ParkingChallengeUtilities();
			string lot = string.Empty;
			bool expected = false;
			bool actual = target.GetParkingAvailability(lot);
			Assert.AreEqual(expected, actual);

			lot = "full";
			expected = false;
			actual = target.GetParkingAvailability(lot);
			Assert.AreEqual(expected, actual);

			lot = "39b";
			expected = true;
			actual = target.GetParkingAvailability(lot);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestCalculateFee()
		{
			var target = new ParkingChallengeUtilities();
			PrivateObject obj = new PrivateObject(target);
			Object[] args;
			TimeSpan hours;
			decimal expectedFee;
			decimal actualFee;

			hours = new TimeSpan(1, 0, 0);
			args = new Object[1] { hours };
			expectedFee = 5.0m;
			actualFee = Convert.ToDecimal(obj.Invoke("CalculateFee", args));
			Assert.AreEqual(expectedFee, actualFee);

			hours = new TimeSpan(3, 0, 30);
			args = new Object[1] { hours };
			expectedFee = 30.08m;
			actualFee = Convert.ToDecimal(obj.Invoke("CalculateFee", args));
			Assert.AreEqual(expectedFee, actualFee);

			hours = new TimeSpan();
			args = new Object[1] { hours };
			expectedFee = 0.0m;
			actualFee = Convert.ToDecimal(obj.Invoke("CalculateFee", args));
			Assert.AreEqual(expectedFee, actualFee);

		}

		[TestMethod]
		public void TestGetParkingFee()
		{
			var target = new ParkingChallengeUtilities();
			string ticket;
			decimal expectedFee;
			decimal actualFee;

			ticket = "1";
			expectedFee = 5.0m;
			actualFee = target.GetParkingFees(ticket);
			Assert.AreEqual(expectedFee, actualFee);

			ticket = "2";
			expectedFee = 25.0m;
			actualFee = target.GetParkingFees(ticket);
			Assert.AreEqual(expectedFee, actualFee);

			ticket = "3";
			expectedFee = 173.5m;
			actualFee = target.GetParkingFees(ticket);
			Assert.AreEqual(expectedFee, actualFee);

			ticket = "59"; //does not exist
			expectedFee = 0.0m;
			actualFee = target.GetParkingFees(ticket);
			Assert.AreEqual(expectedFee, actualFee);
		}
	}
}

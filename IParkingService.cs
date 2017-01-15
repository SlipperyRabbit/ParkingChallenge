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
	/// Parking Service contract definition
	/// </summary>
	[ServiceContract]
	public interface IParkingService
	{
		[OperationContract]
		[WebGet]
		ParkingAvailableType GetParkingAvailability(string lot);

		[OperationContract]
		[WebGet]
		ParkingFeeType GetParkingFee(long ticket);
	}

	[DataContract]
	public class ParkingAvailableType
	{
		bool parkingAvailable = true;

		[DataMember]
		public bool ParkingAvailableValue
		{ 
			get { return parkingAvailable; }
			set { parkingAvailable = value; }
		}
	}

	[DataContract]
	public class ParkingFeeType
	{
		decimal parkingFee = 0.0m;

		[DataMember]
		public decimal ParkingFeeValue
		{ 
			get { return parkingFee; }
			set { parkingFee = value; }
		}
	}
}

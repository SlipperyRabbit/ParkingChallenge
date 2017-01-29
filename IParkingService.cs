using SwaggerWcf.Attributes;
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
		[WebGet(UriTemplate = "/GetParkingAvailability/{lot}",
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json)]
		ParkingAvailableType GetParkingAvailability(string lot);

		[OperationContract]
		//[SwaggerWcfPath("Swagger test", "Test Swagger connectivity and display")]
		[WebGet(UriTemplate = "/GetParkingTest",
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json)]
		bool GetParkingTest();
		
		[OperationContract]
		[WebGet(UriTemplate = "/GetParkingFee/{ticket}", 
		RequestFormat = WebMessageFormat.Json, 
		ResponseFormat = WebMessageFormat.Json)]
		////[WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,	ResponseFormat = WebMessageFormat.Json,		UriTemplate = "/GetParkingFee?ticket={ticket}")]
		ParkingFeeType GetParkingFee(string ticket);
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

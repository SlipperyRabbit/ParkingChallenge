using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingChallengeAPI.Controllers
{
	/// <summary>
	/// Exception test controller
	/// </summary>
    public class ExceptionTestController : ApiController
    {
		/// <summary>
		/// Get a response and trigger an exception
		/// </summary>
		/// <remarks>Use to test Elmah exception handling configuration.</remarks>
		/// <returns>True if exception thrown, otherwise false.</returns>
		public bool Get()
		{
			bool success = false;
			try
			{
				Elmah.ErrorSignal.FromCurrentContext().Raise(new Exception("Test Exception"));
				success = true;
			}
			catch (Exception)
			{
				success = false;
			}
			return success;
		}
	}
}

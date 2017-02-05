using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingChallengeAPI.Controllers
{
	/// <summary>
	/// Test api controller
	/// </summary>
    public class TestController : ApiController
    {
		/// <summary>
		/// Get a test response
		/// </summary>
		/// <returns>True</returns>
		public bool Get()
		{
			return true;
		}
    }
}

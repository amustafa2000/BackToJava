using ODataTest.DataSource;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace ODataTest.Controllers
{
	[EnableQuery]
	public class TripsController : ODataController
	{
		public IHttpActionResult Get()
		{
			return Ok(DemoDataSources.Instance.Trips.AsQueryable());
		}
	}
}
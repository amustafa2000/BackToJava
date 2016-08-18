using ODataTest.DataSource;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace ODataTest.Controllers
{
	[EnableQuery]
	public class PeopleController : ODataController
	{
		public IHttpActionResult Get()
		{
			return Ok(DemoDataSources.Instance.People.AsQueryable());
		}
	}
}
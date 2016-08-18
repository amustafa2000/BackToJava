using ODataTest.Models;
using Microsoft.OData.Edm;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
namespace ODataTest
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
			config.EnsureInitialized();
		}
		private static IEdmModel GetEdmModel()
		{
			ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
			builder.Namespace = "Demos";
			builder.ContainerName = "DefaultContainer";
			builder.EntitySet<Person>("People");
			builder.EntitySet<Trip>("Trips");
			var edmModel = builder.GetEdmModel();
			return edmModel;
		}
	}
}

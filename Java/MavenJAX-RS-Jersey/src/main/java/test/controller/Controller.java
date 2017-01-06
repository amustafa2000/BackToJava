package test.controller;

import java.util.List;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import test.model.Country;
import test.service.DBService;

/**
 * Root resource (exposed at "myresource" path)
 */
@Path("myresource")
public class Controller {

    @GET
    @Produces(MediaType.APPLICATION_JSON)
    public List<Country> getIt() {
    	DBService dbservice = DBService.getInstance();
    	List<Country> countries = dbservice.getAllCountries();
        return countries;
    }
}

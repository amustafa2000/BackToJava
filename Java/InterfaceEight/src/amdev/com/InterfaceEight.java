package amdev.com;

import java.util.function.Supplier;

public class InterfaceEight {
	public static void main( String[] args ) {
	    ExampleDefaulableInterface defaulable = ExampleDefaulableFactory.create( ExampleDefaultableImpl::new );
	    System.out.println( defaulable.exampleNotRequiredMethod() );
	    defaulable.absMethod();    
	    defaulable = ExampleDefaulableFactory.create( ExampleOverridableImpl::new );
	    System.out.println( defaulable.exampleNotRequiredMethod() );
	}
	private interface ExampleDefaulableFactory {
	    // Interfaces now allow static methods
	    static ExampleDefaulableInterface create( Supplier< ExampleDefaulableInterface > supplier ) {
	        return supplier.get();
	    }
	}
	private interface ExampleDefaulableInterface {
	    // Interfaces now allow default methods, the implementer may or 
	    // may not implement (override) them.
	    default String exampleNotRequiredMethod() { 
	        return "Default implementation in exampleNotRequiredMethod"; 
	    }
	    abstract void absMethod();
	}
	private static class ExampleDefaultableImpl implements ExampleDefaulableInterface {

		@Override
		public void absMethod() {
			// TODO Auto-generated method stub
			
		}
	}
	private static class ExampleOverridableImpl implements ExampleDefaulableInterface {
	    @Override
	    public String exampleNotRequiredMethod() {
	        return "Overridden implementation in exampleNotRequiredMethod";
	    }

		@Override
		public void absMethod() {
			// TODO Auto-generated method stub
			
		}
	}
}

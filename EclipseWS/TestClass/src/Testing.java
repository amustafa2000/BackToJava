import java.util.ArrayList;
import java.util.List;

public class Testing {
	{
		System.out.println("I am just a block");
	}
	static {
		System.out.println("I am just a Static block");
	}
	private int y = 1;
	public Testing(){
		List<String> sList = new ArrayList<String>();
		
	}
	Testing getT(){
		try{
			List<String> sList = new ArrayList<String>();
		}
		finally{
			try{
				List<String> sList = new ArrayList<String>();
			}
			finally{
			}
		}
	 return this;
	}
}

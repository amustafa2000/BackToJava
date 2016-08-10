package amdev.com;

import java.util.Arrays;
import java.util.List;

public class LambadaTest {
	public static void main(String[] args) {
		lambadaTest();
	}
	public static void lambadaTest(){
		String[] sAry = new String[3];
		sAry[0] = "a";
		sAry[1] = "b";
		sAry[2] = "d";
		for(int i=0;i<sAry.length;i++){
			System.out.println(i+" = "+sAry[i]);
		}
		Arrays.asList( "a", "b", "d" ).forEach( e -> System.out.println( e ) );
		Arrays.asList( "a", "b", "d" ).forEach( (String e) -> System.out.println( e ) );
		Arrays.asList( "a", "b", "d" ).forEach( (String e) -> {
			System.out.println( e );
			} );
		List<String> strinArray = Arrays.asList( "d", "a", "b" );
		strinArray.sort((e1,e2) ->{
			return e1.compareTo(e2); 
		});
		strinArray.forEach( e -> System.out.println(">>"+ e ) );
	}

}

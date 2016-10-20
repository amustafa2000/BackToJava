import static org.junit.Assert.*;

import org.junit.Test;

public class MyTestCases {

	@Test
	public void testx() {
		MyTestClass mtc = new MyTestClass();
		assertEquals("comments", 5, mtc.add());
	}
}

package amdev.com;

public class DataTypeExample {

	public static void main(String[] args) {
		/*
		 * http://www.tutorialspoint.com/java/java_basic_datatypes.htm
		 * http://docs.oracle.com/javase/tutorial/java/nutsandbolts/datatypes.html
		 */
		allNonFloatNumbers();
		floatAndDoubleDetail();
		charDetals();
		booleanDetails();
	}
	public static void allNonFloatNumbers(){
		/*
		 * LEARN 2's Complement
		 * http://stackoverflow.com/questions/3621067/why-is-the-range-of-bytes-128-to-127-in-java
		 * https://www.youtube.com/watch?v=9W67I2zzAfo
		 */
		byteDetail();
		shortDetail();
		intDetail();
		longDetail();
	}
	public static void byteDetail(){
		/*
		 * The byte data type is an 8-bit signed two's complement integer. 
		 * It has a minimum value of -128 and a maximum value of 127 (inclusive). 
		 * The byte data type can be useful for saving memory in large arrays, where the memory savings actually matters.
		 */ 
		byte bMax = 127; 
		System.out.println("Max byte = " + bMax);
		System.out.println("Max byte Another Way = " + Byte.MAX_VALUE);
		byte bMin = -128;
		System.out.println("Max byte = " + bMin);
		System.out.println("Max byte Another Way = " + Byte.MIN_VALUE);
	}
	public static void shortDetail(){
		/*
		 * The short data type is a 16-bit signed two's complement integer. 
		 * It has a minimum value of -32,768 and a maximum value of 32,767 (inclusive). 
		 * As with byte, the same guidelines apply: you can use a short to save memory in large arrays, in situations where the memory savings actually matters.
		 */
		short shortMax = 127; 
		System.out.println("Max short = " + shortMax);
		System.out.println("Max short Another Way = " + Short.MAX_VALUE);
		short shortMin = -128;
		System.out.println("Max short = " + shortMin);
		System.out.println("Max short Another Way = " + Short.MIN_VALUE);
	}
	public static void intDetail(){
		/*
		 * int: By default, the int data type is a 32-bit signed two's complement integer, which has a minimum value of -2 power 31 and a maximum value of 2 power 31-1. 
		 * In Java SE 8 and later, you can use the int data type to represent an unsigned 32-bit integer, which has a minimum value of 0 and a maximum value of 2 power 32-1. 
		 */
		int i = 12345;
		System.out.println("int: i = " + i);
		System.out.println("Max int Another Way = " + Integer.MAX_VALUE);
		System.out.println("Min int Another Way = " + Integer.MIN_VALUE);
	}
	public static void longDetail(){
		/*
		 * long: The long data type is a 64-bit two's complement integer. The signed long has a minimum value of -2 power 63 and a maximum value of 2 power63-1. 
		 * In Java SE 8 and later, you can use the long data type to represent an unsigned 64-bit long, which has a minimum value of 0 and a maximum value of 2 poser 64-1. 
		 */
		long myLong = 111l;
		long myLong2 = 111L;
		System.out.println("long: myLong = " + myLong);
		System.out.println("long: myLong2 = " + myLong2);
		System.out.println("Max long Another Way = " + Long.MAX_VALUE);
		System.out.println("Min long Another Way = " + Long.MIN_VALUE);
		
	}
	public static void floatAndDoubleDetail(){
		//http://stackoverflow.com/questions/27598078/float-and-double-datatype-in-java
		//https://www.youtube.com/watch?v=MSxzdm4ev_8
		// float myFloat = 12.3; // DOES not work
		/*
		 * float: The float data type is a single-precision 32-bit IEEE 754 floating point.
		 */
		float myFloatf = 122.3f;
		float myFloatF = 122.3F;
		System.out.println("float: myFloatf = " + myFloatf);
		System.out.println("float: myFloatF = " + myFloatF);
		/*
		 * The double data type is a double-precision 64-bit IEEE 754 floating point
		 */
		double myDouble = 12.3;
		double myDoubled = 12.3d;
		double myDoubleD = 12.3D;
		// e is here
		double myDoubleWithe = 1.234e2;
		
		System.out.println("double: myDouble = " + myDouble);
		System.out.println("double: myDoubled = " + myDoubled);
		System.out.println("double: myDoubleD = " + myDoubleD);
		System.out.println("double: myDoubleWith e = " + myDoubleWithe);
	}
	public static void charDetals(){
		/*
		 * char: The char data type is a single 16-bit Unicode character. 
		 * It has a minimum value of '\u0000' (or 0) and a maximum value of '\uffff' (or 65,535 inclusive).
		 */
		char capitalC = 'C';
		System.out.println("char: capitalC = " + capitalC);
	}
	public static void booleanDetails(){
		/*
		 * boolean: The boolean data type has only two possible values: true and false. 
		 * Use this data type for simple flags that track true/false conditions. 
		 * This data type represents one bit of information, but its "size" isn't something that's precisely defined.
		 */
		boolean boolTrue = true;
		boolean boolFalse = false;
		System.out.println("boolean: boolTrue = " + boolTrue);
		System.out.println("boolean: boolFalse = " + boolFalse);
	}
}

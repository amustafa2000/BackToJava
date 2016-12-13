package com.amdev;

import java.rmi.RemoteException;

import sp2013ii.WebServiceTestSoapProxy;

public class WSTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("test");
		WebServiceTestSoapProxy test = new WebServiceTestSoapProxy("http://sp2013ii:13665/WebServiceTest.asmx");
		String returned = "";
		try {
			returned = test.helloWorld();
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println(returned);
	}

}

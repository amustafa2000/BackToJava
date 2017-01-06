package test.service;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import test.model.Country;

public class DBService {
	private static DBService singleton = null;
	private String dbName;
	private String dbUser;
	private String dbPass;
	public static DBService getInstance(){
		String readDBName = "jdbc:mysql://localhost:3306/world";
		String readDBUser = "root";
		String readDBPass = "933malibagh";
		if(singleton == null){
			singleton = new DBService(readDBName, readDBUser, readDBPass);
		}
		return singleton;
	}
	private DBService(String dbName, String dbUser, String dbPass){
		try{
			Class.forName("com.mysql.jdbc.Driver");  
			this.dbName = dbName;
			this.dbPass = dbPass;
			this.dbUser = dbUser;
		}catch(Exception e){
			System.out.println(e);
		}  
	}
	private Connection getConnection(){
		Connection conn = null;
		try {
			conn= DriverManager.getConnection(dbName,dbUser,dbPass);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return conn;
	}
	public List<Country> getAllCountries(){
		List<Country> countries = new ArrayList<Country>();
		try{
			Connection con = this.getConnection();
			Statement stmt=con.createStatement();
			ResultSet rs=stmt.executeQuery("select * from country");  
			while(rs.next()){
				Country c = new Country(rs.getString(1), rs.getString(2), rs.getString(3));
				countries.add(c);
			}
			con.close();
		}catch(Exception e){
			System.out.println(e);
		}
		return countries;
	}
}

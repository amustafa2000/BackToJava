package test.service;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;

import test.model.Country;

public class DBService {
	private static DBService singleton = null;
	private String dbUrl = null;
	private String dbUser = null;
	private String dbPass = null;
	public static DBService getInstance(){
		if(singleton == null || (singleton != null && (singleton.dbUrl == null || singleton.dbUser == null || singleton.dbPass == null))){
			Properties props = new Properties();
			try {
				props.load(Thread.currentThread().getContextClassLoader().getResourceAsStream("config.properties"));
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
			singleton = new DBService(props.getProperty("url"), props.getProperty("username"), props.getProperty("password"));
		}
		return singleton;
	}
	private DBService(String dbName, String dbUser, String dbPass){
		try{
			Class.forName("com.mysql.jdbc.Driver");  
			this.dbUrl = dbName;
			this.dbPass = dbPass;
			this.dbUser = dbUser;
		}catch(Exception e){
			System.out.println(e);
		}  
	}
	private Connection getConnection(){
		Connection conn = null;
		try {
			conn= DriverManager.getConnection(dbUrl,dbUser,dbPass);
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

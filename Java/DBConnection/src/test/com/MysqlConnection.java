package test.com;

import java.sql.*;  
public class MysqlConnection{  

	public static void main(String args[]){
		try{
			Class.forName("com.mysql.jdbc.Driver");
			String dbNameUrl = "jdbc:mysql://localhost:3306/world";
			Connection con=DriverManager.getConnection(dbNameUrl,"root","933malibagh");  
			Statement stmt=con.createStatement();
			ResultSet rs=stmt.executeQuery("select * from country");  
			while(rs.next()){
				System.out.println(rs.getString(1)+"  "+rs.getString(2)+"  "+rs.getString(3));  
			}
			con.close();
		}catch(Exception e){
			System.out.println(e);
		}
	}  
}
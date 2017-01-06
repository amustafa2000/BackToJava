package test.model;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Country {
	private String code;
	private String name;
	private String continent;
	
	public Country(){
	}

	public Country(String code, String name, String continent){
		this.code = code;
		this.name = name;
		this.continent = continent;
	}

	public String getCode() {
		return code;
	}

	public String getName() {
		return name;
	}

	public String getContinent() {
		return continent;
	}
	
	public void setCode(String code) {
		this.code = code;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setContinent(String continent) {
		this.continent = continent;
	}
}

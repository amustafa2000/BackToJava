package amdev.com;
import amdev.com.People;
import java.util.List;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;


public class SortTester {

	public static void main(String[] args) {
		People p1 = new People(3);
		People p2 = new People(2);
		People p3 = new People(1);
		People p4 = new People(4);
		
		List<People> pList = new ArrayList<People>();
		pList.add(p1);
		pList.add(p2);
		pList.add(p3);
		
		Collections.sort(pList, new Comparator<People>() {
			@Override
			public int compare(People o1, People o2) {
				if(o1.age<o2.age)return 1;
				if(o1.age>o2.age)return -1;
				return 0;
			}
		});
		for(int i=0;i<pList.size();i++){
			System.out.println("i= " + i + " pList(i) = " + pList.get(i).age);
		}
		
		Collections.sort(pList, (o1, o2) -> Integer.valueOf(o1.age).compareTo(Integer.valueOf(o2.age)));
		
		for(int i=0;i<pList.size();i++){
			System.out.println("i= " + i + " pList(i) = " + pList.get(i).age);
		}
		
	}

}

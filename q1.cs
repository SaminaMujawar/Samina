/*1) Given two arrays , Write a program that prints numbers from both arrays that are not present in other. 
Sample input 
array_A = {1, 7, 9, 3, 12 }
array_B = {12, 5, 57, 1 }
*/
using System;
public class GFG {
     static void findMissing(int []a, int []b,  
                            int n, int m) 
    { 
        for (int i = 0; i < n; i++) 
        { 
            int j; 
              
            for (j = 0; j < m; j++) 
                if (a[i] == b[j]) 
                    break; 
  
          if(j==m)
                Console.Write(a[i]+" " + b[i]+ " ");
                
        } 
    } 
	static public void Main () {
		int []a = {1, 7, 9, 3, 12 }; 
        int []b = {12, 5, 57, 1 }; 
          
        int n = a.Length; 
        int m = b.Length; 
          
        findMissing(a, b, n, m); 
		
	}
}
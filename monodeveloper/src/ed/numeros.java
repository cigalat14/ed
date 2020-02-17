package ed;
/**
 * 
 * @author ignsae
 *
 */
import java.util.Scanner;

public class numeros {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int numero = 1;
		
		while (numero != 0) {
			System.out.println("Introduce un número (0 para terminar)");
			numero = sc.nextInt();
		}	
		System.out.println("Fin del programa");
	}

}

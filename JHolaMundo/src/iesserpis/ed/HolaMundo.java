package iesserpis.ed;

import java.util.Scanner;

public class HolaMundo {

	public static void main(String[] args) {
		Scanner scanner = new Scanner (System.in);
		String nombre;
		System.out.print("Introduzca su nombre");
		 nombre = scanner.nextLine();
		System.out.print("Hola, "+ nombre);

	}

}

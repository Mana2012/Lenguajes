
package tabla.transicion;

import java.util.Scanner;

public class TablaTransicion {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        String cadena="";
        char cad[];
        int m=0, p=0;
        
        do{
            System.out.println("Ingrese una cadena (salir = s): ");
            cadena = s.nextLine();
            cad=cadena.toCharArray();
            
            for (int i = 0; i < cad.length; i++) {
                if (cad[i]=='0') {
                   m++;
                }else{
                    p++;
                }
            }
            if (((m%2)==0 && (p%2)!=0)) {
                System.out.println("m: "+m+" \np:"+p);
                System.out.println("Cadena Correcta...!!!\n");
            }else{
                System.out.println("m: "+m+" \np:"+p);
                System.out.println("Cadena Incorrecta\n");
            }
            m=p=0;
        }while(!cadena.equals("s"));
    }
}
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>

int main(int argc, char *argv[]) 
{
	
	char nombre [20] = "Antonio";
	int inicio=0;
	int longitud=strlen(nombre);
	int fin=0;
	int x;
	int pal =0;
	for (x=0 ; nombre[x]!= '\0'; x++)
		nombre[x]= toupper(nombre[x]);
	printf ("Tu nombre en mayúsculas es: %s", nombre);
	for (fin=longitud-1 ; nombre[fin]==nombre[inicio]; inicio++ ,fin--);
	if (inicio!=longitud)
		printf ("Tu nombre no es palindromo");
	if (inicio==longitud)
		printf("Tu nombre es palindromo");
		
		
		
	
}





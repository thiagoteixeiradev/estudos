#include<stdio.h>

//dobrar valor por passagem de valor
void dobrarpass(int num) {
	num = num * 2;
	printf("O valor dobrado e %d\n", num);
}

//dobrar o valor por referencia e ponteiro
void dobraref(int* num) {
	*num = *num * 2;
	printf("Segue o valor dobrado pela referência em ponteiro: %d\n", *num);
}

int main() {
	int numero = 10;

	printf("Antes: %d\n", numero);
	dobraref(&numero);
	printf("Agora (Por referencias em ponteiros): %d\n", numero);
	dobrarpass(numero);
	printf("Agora (Por Passagem de valor): %d\n", numero);

	return 0;
}
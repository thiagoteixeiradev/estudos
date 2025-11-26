#include <stdio.h>
#include <stdlib.h>
int main() {
	//Defino as variáveis e ponteiros.
	int numero = 10;
	int* ponteiroInt = &numero; //Ponteiro para inteiro.

	//Exibindo valor e o endereço
	printf("Valor do numero: %d\n", numero);
	printf("Endereco do numero: %p\n", ponteiroInt);
	printf("Valor apontado do ponteiro: %d\n", *ponteiroInt);
	//Alterando o valor da variável através do ponteiro.
	*ponteiroInt = 15;
	printf("Novo valor do numero: %d\n", numero);

	//Caracteristicas especificas dos ponteiros
	//Alocação dinamica
	int* ponteirodinamico;
	ponteirodinamico = (int*)malloc(sizeof(int));
	//validação da alocação
	if (ponteirodinamico == NULL) {
		printf("Erro ao alocar na memória!\n");
		return 1; //saí do programa se a alocação falhar.
	}

	//Inicializando o valor alocado dinamicamente
	*ponteirodinamico = 50;
	printf("Valor armazenado na memoria alocado dinamicamente: %d\n", *ponteirodinamico);

	//Uso correto dos ponteiros
	//Exemplo de uso seguro com verificação e liberação
	free(ponteirodinamico); //libera
	ponteirodinamico = NULL; //invalida o ponteiro

	//testando após liberação
	if (ponteirodinamico == NULL) {
		printf("Memoria liberada e ponteiro invalidado");
	}
	return 0;

}
#include<stdio.h>
#include<stdlib.h>
int main() {
	int* ponteiro;
	//ponteiro = (int*)malloc(5 * sizeof(int)); //exemplo malloc
	ponteiro = (int*)calloc(5, sizeof(int)); //exemplo calloc
	//Aloca memória para 5 inteiros
	if (ponteiro != NULL) {// verifica se foi alocado
		int i;
		for (i = 0; i < 5; i++) {
			ponteiro[i] = i + 1; //inicia os valores manualmente
		}
		for (i = 0; i < 5;i++) {
			printf("%d ", ponteiro[i]); //faz a contagem
		}
		free(ponteiro);
	}
}
#include<stdio.h>
#include<string>
#define _CRT_SECURE_NO_WARNINGS
#define NUM_PRODUTOS 2

struct Produto {
	char nome[10];
	int codigo;
	int quantidade;
	float preco;
};
int main() {
	int i;
	struct Produto produtos[NUM_PRODUTOS];

	//Preenchendo dados
	strcpy_s(produtos[0].nome, "Camiseta");
	produtos[0].codigo = 101;
	produtos[0].quantidade = 50;
	produtos[0].preco = 29,99;

	strcpy_s(produtos[1].nome, "Calca");
	produtos[1].codigo = 100;
	produtos[1].quantidade = 60;
	produtos[1].preco = 59,99;

	for (i = 0; i < 2; i++) {
		printf("Produto %d:\n", i + 1);
		printf("  Nome: %s\n", produtos[i].nome);
		printf("  Codigo: %d\n", produtos[i].codigo);
		printf("  Quantidade: %d\n", produtos[i].quantidade);
		printf("  Preco: R$ %.2f\n\n", produtos[i].preco);
	}
}

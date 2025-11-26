#include<stdio.h>;
#include<string.h>;

struct Pessoa{
	char nome[50];
	int idade;
	char telefone[15];
};

int main() {
	struct Pessoa lista[3];
	int i;

	//Alocando os dados
	strcpy(lista[0].nome, "Romario");
	lista[0].idade = 30;
	strcpy(lista[0].telefone, "83993337869");

	strcpy(lista[1].nome, "Macielly");
	lista[1].idade = 34;
	strcpy(lista[1].telefone, "83986618075");

	strcpy(lista[2].nome, "Yasmin");
	lista[2].idade = 12;
	strcpy(lista[2].telefone, "0000000000");

	//Imprimindo os dados
	for (i = 0; i < 3; i++) {
		printf("Nome: %s\n", lista[i].nome);
		printf("Idade: %d\n", lista[i].idade);
		printf("Telefone: %s\n", lista[i].telefone);
	}
	return 0;
}
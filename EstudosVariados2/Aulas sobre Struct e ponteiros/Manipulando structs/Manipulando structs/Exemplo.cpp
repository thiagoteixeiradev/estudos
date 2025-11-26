#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Pacientes{
	char nome[30];
	int idade;
	char cadastro[10];
};

int main() {
	struct Pacientes paciente[2];
	int i;

	strcpy(paciente[0].nome, "Romario Braz");
	paciente[0].idade = 30;
	strcpy(paciente[0].cadastro, "2345678");

	strcpy(paciente[1].nome, "Joao");
	paciente[1].idade = 25;
	strcpy(paciente[1].cadastro, "123456");

	//paciente[1] = paciente[0];

	//exibindo os dados
	for (i = 0; i < 2; i++) {
		printf("Nome do paciente: %s\n", paciente[i].nome);
		printf("Idade: %d\n", paciente[i].idade);
		printf("Cadastro: %s\n\n", paciente[i].cadastro);
	}
	return 0;
}
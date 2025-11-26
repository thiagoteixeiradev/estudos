#define _CRT_SECURE_NO_WARNINGS
#include < stdio.h >
#include < stdlib.h >

int main() {
	FILE *arquivo; //ponteiro para o arquivo
	char nome[30];
	int idade;

	//Abrindo arquivo no modo escrita
	arquivo = fopen("dados.txt", "w");
	if (arquivo == NULL) {
		printf("Erro ao abrir o arquivo!");
		return 1;
	}

	//Coletando os dados
	printf("Digite seu nome: ");
	scanf("%s", nome);
	printf("Digite a idade: ");
	scanf("%d", &idade);

	//Gravando dados
	fprintf(arquivo, "Nome: %s\nIdade: %d\n", nome, idade);

	//Fechando arquivo
	fclose(arquivo);

	//Abrindo no modo leitura
	arquivo = fopen("dados.txt", "r");
	if (arquivo == NULL) {
		printf("Erro ao abrir o arquivo!");
		return 1;
	}

	//lendo os dados do arquivo
	fscanf(arquivo, "Nome: %s\nIdade: %d\n", nome, &idade);

	//Exibindo dados lidos
	printf("Dados do arquivo:\n");
	printf("Nome: %s\nIdade: %d\n", nome, &idade);

	//fechando
	fclose(arquivo);

	return 0;
}
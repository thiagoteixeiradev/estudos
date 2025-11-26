#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h> // para usar strcpy

struct Idade {
    int idade;
};

struct Nome {
    char nome[30];
};

struct Pessoa {
    struct Idade idade[2];
    struct Nome nome[2];
};

void CadastraPessoa(struct Pessoa* pessoa) {
    pessoa->idade[0].idade = 10;
    strcpy(pessoa->nome[0].nome, "Romario");

    pessoa->idade[1].idade = 15;
    strcpy(pessoa->nome[1].nome, "Romario2");
}

int main() {
    struct Pessoa pessoa1;
    CadastraPessoa(&pessoa1);
    printf("%s\n", pessoa1.nome[0].nome);
    printf("%s\n", pessoa1.nome[1].nome);
    return 0;
}
package testes;

import java.util.Scanner;

public class CadastroAlunos {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] alunos = new String[5];
        double[] notas = new double[5];
        int quantidadeAlunos = 0;
        int opcao;

        do {
            System.out.println("Menu:");
            System.out.println("1. Cadastrar nome de aluno");
            System.out.println("2. Cadastrar nota de aluno");
            System.out.println("3. Exibir lista de alunos e suas notas");
            System.out.println("4. Sair");
            System.out.print("Escolha uma opção: ");
            opcao = scanner.nextInt();

            switch (opcao) {
                case 1:
                    // Usando while para cadastrar nomes de alunos até que o array esteja cheio
                    while (quantidadeAlunos < alunos.length) {
                        System.out.print("Digite o nome do aluno " + (quantidadeAlunos + 1) + ": ");
                        alunos[quantidadeAlunos] = scanner.next();
                        quantidadeAlunos++;
                        if (quantidadeAlunos < alunos.length) {
                            System.out.print("Deseja cadastrar outro aluno? (s/n): ");
                            char resposta = scanner.next().charAt(0);
                            if (resposta == 'n' || resposta == 'N') {
                                break;
                            }
                        }
                    }
                    if (quantidadeAlunos == alunos.length) {
                        System.out.println("Capacidade máxima de alunos atingida!");
                    }
                    break;

                case 2:
                    // Usando for para cadastrar as notas dos alunos já registrados
                    for (int i = 0; i < quantidadeAlunos; i++) {
                        System.out.print("Digite a nota do aluno " + alunos[i] + ": ");
                        notas[i] = scanner.nextDouble();
                    }
                    break;

                case 3:
                    // Usando for para exibir os alunos e notas
                    System.out.println("Lista de alunos e suas notas:");
                    for (int i = 0; i < quantidadeAlunos; i++) {
                        System.out.println("Aluno: " + alunos[i] + " - Nota: " + notas[i]);
                    }
                    break;

                case 4:
                    System.out.println("Saindo do programa...");
                    break;

                default:
                    System.out.println("Opção inválida!");
            }

            // Laço do-while para manter o menu ativo até que o usuário escolha sair
        } while (opcao != 4);

        scanner.close();
    }
}

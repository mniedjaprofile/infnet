let alunos = [];
let notas = [];
let quantidadeAlunos = 2;
let opcao;

do{
  opcao = parseInt(prompt("Menu:\n"+
    "1. Cadastrar nome de aluno\n"+
    "2. Cadastrar nota de aluno\n"+
    "3. Exibir lista de alunos e suas notas\n"+
    "4. Sair\n"+
    "Escolha uma opção: "));

  switch(opcao){
    case 1:
      for(let i = 0; i < quantidadeAlunos; i++){
        let nome = prompt("Digite o nome do aluno: ");
  
        alunos.push(nome);
      }
      break;
      
    case 2:
      for(let i = 0; i < quantidadeAlunos; i++){
        let nota = parseFloat(prompt(`Digite a nota do aluno ${alunos[i]}:`));
        
        notas.push(nota);
      }
      
      break;
      
    case 3:
      let resultado = "Lista de alunos e suas notas:\n";      
      for(let i = 0; i < quantidadeAlunos; i++){
        resultado = resultado + `${alunos[i]} - ${notas[i]}\n` 
      }
      alert(resultado);
      break;

    case 4:
      alert("4. Sair");
      break;
      
    default:
      alert(`Opção inválida: ${opcao}`);
}

} while (opcao != 4);
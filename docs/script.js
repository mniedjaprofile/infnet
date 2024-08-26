/*
Cadastro de alunos 16-08

let alunos = [];
let notas = [];
let quantidadeAlunos = 5;
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
 */

  function daysDate(){
    let days = ['SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT'];
    let message = " ";

      for(i in days){
        message += 'Day ' +i  +' is ' +days[i]  + '\n';
      }
      alert(message);
  }
  //daysDate();

function formaterDate(){
  let myDate = new Date();
  let day = myDate.getDay();

 switch(day){
    
    case 0: 
      alert("It's Sunday! Time to relax and recharge for the week ahead.");
      break;

    case 1:
        alert("Happy Monday! Let's start the week with some positive energy.");
        break;
    case 2:
        alert("It's Tuesday! Keep the momentum going.");
        break;
    case 3:
        alert("It's Wednesday! You're halfway through the week.");
        break;
    case 4:
        alert("It's Thursday! The weekend is almost here.");
        break;
    case 5:
        alert("Happy Friday! The weekend is just around the corner.");
        break;
    case 6:
       alert("It's Saturday! Enjoy your weekend to the fullest.");
        break;
    default:
        alert("Oops! Something went wrong with getting the day.");

  }
}

formaterDate();

function months(){
  let months = ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho',
                'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'];

  for(i = 0; i < months.length; i++){
    console.log(`Mês ${i +1}: ${months[i]}`);
  }
}
months();
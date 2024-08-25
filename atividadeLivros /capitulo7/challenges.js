/* 
1- Escreva um loop que conte de 1 a 100 e verifique se o número é 
múltiplo de 3 ou 5. Se for múltiplo de 3, ele deverá registrar 
“Fizz” no console. Se for um múltiplo de 5, deverá registrar “Buzz” 
no console. Se for um múltiplo de 3 e 5, deverá registrar “FizzBuzz” 
no console e, se não for múltiplo de nenhum deles, deverá apenas 
registrar o número no console.

2- No último capítulo, escrevemos algum código para um jogo superior 
ou inferior, mas isso apenas deu ao usuário uma chance de adivinhar o 
valor superior ou inferior. Escreva algum código que permita ao usuário
continuar adivinhando até errar. Também deve dizer quantas vezes eles 
conseguiram adivinhar corretamente no final do jogo.

3- In the last chapter, we wrote a times table question game 
(challenge 3). Modify the code so that it asks five questions 
and keeps score of how many the user gets right
*/

//1

for(let cont = 1; cont <= 100; cont++){
   if(cont % 3 === 0 && cont % 5 === 0){
        console.log("FizzBuzz"); 
   } else if (cont % 3 === 0){
        console.log("Fizz");
   } else if (cont % 5 === 0){
        console.log("Buzz");
   } else {
    console.log(cont);
   }
}

//2 
let playGame = true;
let respostasCertas = 0;
let proximoNumber = Math.floor(Math.random() * 100) +1;

while(playGame){
    let numeroAtual = Math.floor(Math.random() * 100) +1;
    let entradaUsuario = prompt(`O proximo numero é superior ou inferior a ${proximoNumber}? Digite S para superior ou I para inferior): `);

    if((entradaUsuario === 'S' && numeroAtual > proximoNumber) || (entradaUsuario === 'I' && entradaUsuario < proximoNumber)){
        alert(`Você acertou! O proximo numero era ${numeroAtual}`);
        respostasCertas++;
        proximoNumber = numeroAtual;
    }else{
        alert(`Você errou! O proximo numero era ${numeroAtual}`);
        playGame =false;
    }
}

alert(`Fim de jogo! Você acertou ${respostasCertas} vezes.`);
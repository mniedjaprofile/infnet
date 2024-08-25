let planetas = [];

planetas.push("Mercurio");
planetas.push("Venus");
planetas.push("Terra");
planetas.push("Marte");
planetas.push("Jupiter");

//alert("Tamanho do array: " + planetas.length);

planetas[5] = "Saturno";

//alert("Tamanho do array: " + planetas.length);

planetas.push("Urano");

planetas.splice(2, 1);

planetas.push("Netuno");

planetas.push("Plutao");

//alert("Planetas: " + planetas + "!");

planetas.pop();

alert("Planetas: " + planetas + "!");

//for
for(let i = 0; i < 5; i++){
  //alert("for " + (i+1));
}

//while
let i = 0;
while(i < 5){
  //alert("while " + (i+1));  
  i++;
}

//dowhile
let y = 0;
do{
  //alert("dowhile " + (y+1));
  y++;
}while(y < 5);

let soma = 0;
let salario = 0;
for(let i = 0; i < 10; i++){
  salario = parseFloat(prompt("Informe o salário: "));
  
  soma = soma + salario;
}
alert(soma);

//chinês:
//soma = 0, 100
//salario = 0, 100 
//i = 0, 1
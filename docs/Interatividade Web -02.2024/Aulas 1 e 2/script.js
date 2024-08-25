//Criação literal de objetos - declarar  já utilizar os dados declarados a ele.
document.write("<strong>==Área de testes e exercicios==</strong><br>");

const pessoa = {
    primeiroNome: "Mayara",
    ultimoNome: "Araujo",
    email: "mayaraniedja@gmail.com",
    nomeCompleto: function(){
        return this.primeiroNome + " " +this.ultimoNome + "<br>";
    }
};

document.write(pessoa.primeiroNome + "<br>" + 
                pessoa.ultimoNome + "<br>" +
                pessoa.email + "<br>" + 
                pessoa.nomeCompleto() + "<br>");

const quadrado = {
    lado: 1.2,
    area: function(){
        return this.lado * this.lado;
    }
}

document.write("Utilizando função no atributo <br> " + "Area do quadrado é " +quadrado.area()+"<br>");

//Criação de objeto atraves da palavra new.

const pessoa2 = new Object();
    pessoa2.firstName = "Priscila";

    document.write("Escrita de propriedade de um objeto criado com new object()<br>" +pessoa2.firstName + "<br>");

//Modelo pre-definido
function Person (first, last, eye, age){
    this.firstName = first;
    this.lastName = last;
    this.eyeColor = eye;
    this.age = age;
}

const objectCustom = new Person("Maria", "Godoi", 36, "preto");
document.write('No objeto pre-definido o primeiro nome é: ' +objectCustom.firstName+ " <br>" );
document.write('A Cor dos olhos é: '+objectCustom.age + "<br><br>");

const mySelf = new Person("Mayara","Araujo", 34, "Castanho Claro");

const myWife = new Person("Priscila", "Godoi",  "Castanho Caramelo",35);

const myMother = new Person("Nazidir", "Braz", "Castanho Escuro", 56);
const mySister = new Person("Danielle", "Matias",  "Marrom", 45);

document.getElementById("demo").innerHTML = "My wife is " +myWife.firstName + " my mother have "+myMother.age + " old years.";


document.getElementById("ref1").innerHTML = `<a href="https://www.w3schools.com/js/">REF1- W2Shool</a><br>
    <a href ="https://developer.mozilla.org/pt-BR/">REF2- Mozilla</a><br>`;
 
//document.getElementById("objectClass").innerHTML = "Ola";

const cadastroPerson = {
    name: ["Bob Dylan","Maria Fernanda", "Mauricio Araujo"],
    idade: 34,
    sexo: "Masculino",
    interesse: ["bike", "musica"],
    bio: function() {
        alert(
            this.name[0] +
            " e " + 
            this.name[1] +
            "tem " + 
            this.idade +
            " anos de idade. Eles gostam de " +
            this.interesse[0] +
            " e " + 
            this.interesse[1] + "."
        );
    },
    saudacao: function(){
        alert("Oie, sou " +this.name[0] + ".");
    }
};

class car {
    constructor (marca, modelo){
        this.marca = marca;
        this.modelo = modelo;
    }
}
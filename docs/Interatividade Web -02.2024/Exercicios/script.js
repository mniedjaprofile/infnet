class Car{
    constructor(marca, modelo, placa, ano){
        this.marca = marca;
        this.modelo = modelo;
        this.placa = placa;
        this.ano = ano;
    }
}

// == Herança ==

//= Definindo class animal

class animal {
    constructor(nome){
        this.nome = nome;
    }
    fazerSom(){
        let som = "Fazendo som....";
        return som;
    }
}

//= definindo classe cachorro que herda de animal

class cachorro extends animal {
    constructor(nome, raca){
        super(nome); // chama o construtor da classe pai (animal)
        this.raca = raca;
    }
    latir(){
        let msg = "au au au ";
        return msg;
    }
    toString(){
        return `${this.nome} é um ${this.raca}`;
    }
}

const produto = {
    nome: "notebook",
    valorUnitario: 2500.00,
    marca: "Dell"
};

const venda = {
    codigo: 12345,
    data: new Date(),
    produto: produto
};
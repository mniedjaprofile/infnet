// Arrays
let clientes = [];
let incidentes = [];

// Gerador de ID
function geradorId(arrId) {
  const caracteres = "abcdefghijklmnopqrstuvwxyz0123456789";
  let result = "";
  for (let i = 0; i < arrId; i++) {
    let char = caracteres[Math.floor(Math.random() * caracteres.length)];
    result += Math.random() > 0.5 ? char.toUpperCase() : char;
  }
  return result;
}

// Função para exibir clientes
function viewClientes() {
  const listaClientes = document.getElementById("listaClientes");
  listaClientes.innerHTML = "";

  clientes.forEach((cliente) => {
    const item = document.createElement("li");
    item.classList.add("list-group-item");
    item.textContent = `ID: ${cliente.id} | Cliente: ${cliente.nome} | Produto: ${cliente.produto}`;

    listaClientes.appendChild(item);
  });

  document.getElementById("listaClientesSection").classList.remove("hide");
}

// Função para adicionar clientes
function addCliente(nome, email, tel, produto) {
  const cliente = {
    id: geradorId(18),
    nome: nome,
    email: email,
    telefone: tel,
    produto: produto,
  };
  clientes.push(cliente);
}

// Carregar clientes no select de incidente
function carregarClientesNoSelect() {
  const clienteSelect = document.getElementById("clienteIncidente");
  clienteSelect.innerHTML = "<option value=''>Selecione um cliente</option>";

  clientes.forEach((cliente) => {
    const option = document.createElement("option");
    option.value = cliente.id;
    option.textContent = cliente.nome;
    clienteSelect.appendChild(option);
  });
}

// Limpa formulário de cliente
function limparFormularioCliente() {
  document.getElementById("formClient").reset();
}

// Gerenciar o evento de salvar cliente
document.getElementById("formClient").addEventListener("submit", (event) => {
  event.preventDefault();

  const nomeCliente = document.getElementById("nomeCliente").value;
  const produtoCliente = document.getElementById("produtoCliente").value;
  const email = document.getElementById("emailContato").value;
  const telefone = document.getElementById("telefoneContato").value;

  if (nomeCliente && produtoCliente) {
    addCliente(nomeCliente, email, telefone, produtoCliente);

    // Exibe modal de confirmação
    const modal = document.getElementById("confirmarContatoModal");
    modal.classList.remove("hide");
    modal.classList.add("show");
    document.getElementById("clienteForm").classList.add("hide");
  }
});

/// Eventos do modal de confirmação
document.getElementById("confirmarSim").addEventListener("click", () => {
  
  document.getElementById("clienteForm").classList.add("hide");
  document.getElementById("confirmarContatoModal").classList.add("hide");
  document.getElementById("incidenteForm").classList.remove("hide");

  // Carrega os clientes no select do formulário de incidente
  carregarClientesNoSelect();
});

document.getElementById("naoCriarIncidente").addEventListener("click", () => {
  const formCliente = document.getElementById("clienteForm");
  const modal = document.getElementById("confirmarContatoModal");
  modal.classList.remove("show");
  formCliente.classList.add("show");
  modal.classList.add("hide");

});

document.getElementById("closeModal").addEventListener("click", () => {
  const modal = document.getElementById("confirmarContatoModal");
  modal.classList.add("hide");

});
// Função para fechar o modal e restaurar o formulário de cliente
function fecharModal() {
  const modal = document.getElementById("confirmarContatoModal");
  modal.classList.add("hide");
  document.getElementById("clienteForm").classList.remove("hide");
  limparFormularioCliente();
}

// Gerenciar o formulário de incidente e criar um incidente
document.getElementById("formIncidente").addEventListener("submit", (event) => {
  event.preventDefault();

  const clienteId = document.getElementById("clienteIncidente").value;
  const descricaoIncidente = document.getElementById("descricaoIncidente").value;
  const prioridadeIncidente = document.getElementById("prioridadeIncidente").value;

  if (clienteId && descricaoIncidente && prioridadeIncidente) {
    const incidente = {
      id: geradorId(18),
      clienteId: clienteId,
      descricao: descricaoIncidente,
      prioridade: prioridadeIncidente,
    };

    // Oculta formulário de incidente após a criação
    document.getElementById("incidenteForm").classList.add("hide");

    // Loga o incidente no console (pode ser substituído por lógica de persistência)
    console.log("Incidente criado com sucesso:", incidente);
  }
});

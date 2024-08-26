
document.addEventListener("DOMContentLoaded", () => {
        const cepInput = document.getElementById("cep");cepInput.addEventListener("blur", () => {
        
            const cep = cepInput.value.replace(/\D/g, ''); // Remove qualquer caractere não numérico
    
            if (cep.length === 8) { // Verifica se o CEP tem 8 dígitos
                fetch(`https://viacep.com.br/ws/${cep}/json/`)
                    .then(response => response.json())
                    .then(data => {
                        if (!data.erro) {
                            displayResult(data);
                        } else {
                            displayError("CEP não encontrado.");
                        }
                    })
                    .catch(() => displayError("Erro ao buscar o CEP."));
            } else {
                displayError("Por favor, insira um CEP válido com 8 dígitos.");
            }
        });
    
        function displayResult(data) {
            const resultDiv = document.getElementById("result");
            resultDiv.innerHTML = `
                <p><strong>Logradouro:</strong> ${data.logradouro}</p>
                <p><strong>Bairro:</strong> ${data.bairro}</p>
                <p><strong>Cidade:</strong> ${data.localidade}</p>
                <p><strong>Estado:</strong> ${data.uf}</p>
            `;
        }
    
        function displayError(message) {
            const resultDiv = document.getElementById("result");
            resultDiv.innerHTML = `<p style="color: red;">${message}</p>`;
        }
    });
// Script para manipulações da tela de navegação
// Pode incluir a lógica para carregar diferentes formulários de cadastro conforme o menu selecionado

document.querySelectorAll(".sidebar a").forEach((link) => {
  link.addEventListener("click", function (event) {
    event.preventDefault();
    const selectedOption = this.textContent;
    alert(`Você selecionou: ${selectedOption}`);
    // Lógica para carregar o formulário correspondente pode ser adicionada aqui
  });
});

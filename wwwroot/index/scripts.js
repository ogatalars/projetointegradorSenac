document
  .getElementById("loginForm")
  .addEventListener("submit", function (event) {
    event.preventDefault();
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

    fetch("/api/login", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ email: email, password: password }),
    })
      .then((response) => {
        if (response.ok) {
          return response.json();
        } else {
          throw new Error("Login failed");
        }
      })
      .then((data) => {
        alert("Login successful!");
        window.location.href = "../navigation/navigation.html"; // redireciona para a página de navegação
      })
      .catch((error) => {
        console.error("Error:", error);
        alert("Login failed. Please check your credentials and try again.");
      });
  });

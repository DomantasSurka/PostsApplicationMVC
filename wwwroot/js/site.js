function checkIfNotEmpty() {
    var input = document.getElementById("search-input").value;
    var error = document.getElementById('error-message');
    if (input == "") {
        error.innerHTML = "*Enter a valid UserID";
        return false;
    };
}
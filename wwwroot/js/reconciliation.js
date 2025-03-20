document.getElementById("reconciliation").addEventListener("click", function (event) {
    event.preventDefault(); // Prevent navigation
    event.stopPropagation(); // Stop event from bubbling
    document.getElementById("popup-overlay").style.display = "flex";
});

function closePopup() {
    document.getElementById("popup-overlay").style.display = "none";
    window.location.href = "#";
}

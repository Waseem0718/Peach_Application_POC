document.addEventListener("DOMContentLoaded", function () {
    const menuIcon = document.getElementById("menu-icon");
    const menuBar = document.getElementById("menu-bar");
    const closeBtn = document.getElementById("close-btn");

    // Show menu and hide menu icon on menu icon click
    menuIcon.addEventListener("click", function () {
        menuBar.style.transform = "translateX(0)";
        menuIcon.style.display = "none"; // Hide the menu icon
    });

    // Hide menu and show menu icon on close button click
    closeBtn.addEventListener("click", function () {
        menuBar.style.transform = "translateX(100%)";
        menuIcon.style.display = "block"; // Show the menu icon
    });
});

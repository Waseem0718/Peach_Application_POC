// Function to toggle the entire FAQ section
function toggleFAQ() {
    let content = document.getElementById("faq-content");
    let mainArrow = document.getElementById("main-arrow");

    if (content.style.display === "block") {
        content.style.display = "none";
        mainArrow.innerHTML = "&#9660;"; // Down arrow
    } else {
        content.style.display = "block";
        mainArrow.innerHTML = "&#9650;"; // Up arrow
    }
}

// Function to toggle individual FAQ items
function toggleItem(element) {
    let answer = element.querySelector(".faq-answer");
    let arrow = element.querySelector(".faq-arrow");

    if (answer.style.display === "block") {
        answer.style.display = "none";
        arrow.innerHTML = "&#9660;"; // Change to down arrow
    } else {
        answer.style.display = "block";
        arrow.innerHTML = "&#9650;"; // Change to up arrow
    }
}

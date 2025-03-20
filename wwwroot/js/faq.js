document.addEventListener("DOMContentLoaded", function () {
    // Toggle FAQ Sections
    document.querySelectorAll(".faq-header").forEach(header => {
        header.addEventListener("click", function () {
            let content = this.nextElementSibling;
            let arrow = this.querySelector(".arrow");

            if (content.style.display === "block") {
                content.style.display = "none";
                arrow.innerHTML = "&#9660;"; // Down arrow
            } else {
                content.style.display = "block";
                arrow.innerHTML = "&#9650;"; // Up arrow
            }
        });
    });

    // Toggle Individual Questions
    document.querySelectorAll(".faq-question").forEach(question => {
        question.addEventListener("click", function () {
            let answer = this.nextElementSibling;
            let arrow = this.querySelector(".faq-arrow");

            if (answer.style.display === "block") {
                answer.style.display = "none";
                arrow.innerHTML = "&#9660;"; // Down arrow
            } else {
                answer.style.display = "block";
                arrow.innerHTML = "&#9650;"; // Up arrow
            }
        });
    });
});
function toggleButton(selected) {
    const yesBtn = document.getElementById("yesBtn");
    const noBtn = document.getElementById("noBtn");

    if (selected === "yes") {
        yesBtn.classList.add("active");
        noBtn.classList.remove("active");
    } else {
        noBtn.classList.add("active");
        yesBtn.classList.remove("active");
    }
}

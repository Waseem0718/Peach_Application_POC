function toggleTransferType() {
    let transferText = document.getElementById("transferText");
    let dateToContainer = document.getElementById("dateToContainer");
    let isTemporary = document.querySelector('input[name="transferType"]:checked').value === "Temporary";

    if (isTemporary) {
        transferText.innerHTML = "Please select the branch (or branches) that you wish to temporarily transfer.";
        dateToContainer.style.display = "block";
    } else {
        transferText.innerHTML = "Please select the branch (or branches) that you wish to permanently transfer.";
        dateToContainer.style.display = "none";
    }
}

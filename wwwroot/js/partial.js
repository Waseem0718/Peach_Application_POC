
    //document.addEventListener("DOMContentLoaded", function () {
    //    document.querySelectorAll(".nav-link").forEach(link => {
    //        link.addEventListener("click", function (event) {
    //            event.preventDefault();
    //            var section = this.getAttribute("data-content");
    //            var empNumber = document.querySelector("input[value='@ViewBag.Employee.EmployeeNumber']").value;

    //            fetch(`/Employee/LoadSection?employeeNumber=${empNumber}&section=${section}`, {
    //                headers: { "X-Requested-With": "XMLHttpRequest" }
    //            })
    //                .then(response => response.text())
    //                .then(html => {
    //                    document.querySelector(".sub-division").innerHTML = html;
    //                })
    //                .catch(error => console.error("Error loading section:", error));
    //        });
    //    });
    //});

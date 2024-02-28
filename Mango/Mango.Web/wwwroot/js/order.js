/*
var dataTable; 

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: "/order/getall" },
        "columns": [
            { data: 'orderheaderid', "width": "5%" },
            { data: 'email', "width": "25%" },
        ]
    });
}

*/
/*
document.addEventListener("DOMContentLoaded", function () {
    loadData();
});

function loadData() {
    fetch("/order/getall")
        .then(response => response.json())
        .then(data => {
            const tableBody = document.querySelector("#tblData tbody");
            tableBody.innerHTML = "";
            data.forEach(item => {
                const row = document.createElement("tr");
                row.innerHTML = `
                    <td>${item.orderheaderid}</td>
                    <td>${item.email}</td>
                `;
                tableBody.appendChild(row);
            });
        })
        .catch(error => console.error("Error fetching data:", error));
}
*/

/*
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    $('#tblData').DataTable({
        "ajax": { url: "/order/getall" },
        "columns": [
            { data: 'orderheaderid', "width": "5%" },
            { data: 'email', "width": "25%" },
        ]
    });
}
*/

document.addEventListener("DOMContentLoaded", function () {
    loadData();
});

function loadData() {
    fetch("/order/getall")
        .then(response => response.json())
        .then(data => {
            const table = $('#tblData').DataTable({
                "data": data,
                "columns": [
                    { "data": "orderheaderid", "title": "ID", "width": "5%" },
                    { "data": "email", "title": "Email", "width": "25%" },
                    // Add more columns here as needed
                ]
            });
        })
        .catch(error => console.error("Error fetching data:", error));
}


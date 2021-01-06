$(document).ready(function () {

    var productTable = $("#productTable tbody");
    $.ajax({
        url: "/api/ProductsAPI/List",
        method: "GET",
        success: function (data) {
            $.each(data, function (index, value) {
                productTable.append("<tr><td>" + value.ProductName +
                    "</td><td>" + value.Price +
                    "<td>" + value.Discount + "</td>" +
                    "</td ></tr > ");
            });
        },
        error: function (a, b, c) {
            console.log(a);
            console.log(b);
            console.log(c);
        }
    });

    $("#productDropdown").on("change", function () {
        var selectedID = $(this).val();
        var url = "/api/ProductsAPI/List";
        if (selectedID && (1 * selectedID) > 0) {
            url = "/api/ProductsAPI/Search?id=" + $(this).val();
        }
        $.ajax({
            url: url,
            method: "GET",
            success: function (data) {
                productTable.html("");
                $.each(data, function (index, value) {
                    productTable.append("<tr><td>" + value.ProductName +
                        "</td><td>" + value.Price +
                        "<td>" + value.Discount + "</td>" +
                        "</td ></tr > ");
                });
            },
            error: function (a, b, c) {
                console.log(a);
                console.log(b);
                console.log(c);
            }
        });
    });

});
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body class="container-fluid"> 


    <div class="row">
        <!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
 ADD Customer
</button>

                <div id="Show_Customer"> </div> 
        
    </div>
    <script src="https://code.jquery.com/jquery-3.7.1.js" integrity="sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4=" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

    <!-- Button trigger modal -->

    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">add Customer</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col">
                            <label>Create Bil Date</label>
                            <input type="date" id="Create_Date" />
                        </div>
                        <div class="col">
                            <label>Mobile Number</label>
                            <input type="text" id="Mobile_Number" />
                        </div>
                        <div class="col">
                            <label>Delivery Date</label>
                            <input type="date" id="Delivery_date" />
                        </div>
                        <div class="col">
                            <button type="button" class="btn btn-primary" onclick="Save_Consumer_Details()">Save</button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>


    <div class="modal fade" id="itemModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="">Modal title</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    
                   <input type="hidden" id="Biil_id_hidden" />
                   <input type="hidden" id="item_id" />
                    <%-- Details --%>
                    <div class="row">
                        <div class="Col">
                            <label>item Name</label>
                            <input type="text" id="item_Name" />
                        </div>
                        <div class="Col">

                            <label>Number of Item</label>
                            <input type="text" id="Number_of_item" />
                        </div>
                        <div class="Col">
                            <label>Item Price</label>
                            <input type="text" id="item_price" />
                        </div>
                          <div class="Col">
                            <label> total Amount</label>
                            <input type="text" id="total_Amount" />
                        </div>
                       
                        <div class="col">
                            
                            <button type="button" class="btn btn-primary" onclick="Save_item()">Save</button>
                        </div>
                    </div>

                    <br />
                    <div id="Show_item_List">

                    </div>

                    <br />

                    <br />

                    <div >
                        <label id="Total_item"></label>
                    </div>
                    
                    <div >
                        <label id="Total_Amount"></label>
                    </div>
                </div>

            </div>
        </div>
    </div>

</body>
</html>

<script>
    $(function () {
        get_customer();
    });


    // Add Consumer

    function Save_Consumer_Details() {
        var Create_Date = $('#Create_Date').val();
        var Mobile_Number = $('#Mobile_Number').val();
        var Delivery_date = $('#Delivery_date').val();
    
        if (Mobile_Number == "") {
            alert("enter Mobile number");
            return false;
        }

        if (Delivery_date == "") {
            alert("enter Delivery Date");
            return false;
        }


        var data = {
            Create_Date: Create_Date,
            Mobile_Number: Mobile_Number,
            Delivery_date: Delivery_date
        }
        jQuery.ajax({
            type: "POST",
            url: "WebForm1.aspx/Save_Customer_Details",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log(response);
                if (response.d.length > 0) {
                    $("#Show_Customer").empty();
                    var table = jQuery("<table class='table'>").append("<thead><tr><th>Sr No.</th><th>Mobile</th><th>Create_Date</th><th>Delivery_date</th><th>Add Item</th></tr></thead>");
                    var tbody = jQuery("<tbody>");

                    var j = 1;
                    for (var i = 0; i < response.d.length; i++) {
                        var row = jQuery("<tr>").append("<td>" + j + "</td><td>" + response.d[i].Mobile_Number + "</td><td>" + response.d[i].Create_Date + "</td><td>" + response.d[i].Delivery_date + "</td><td><button type='button' onclick='Add_item(" + response.d[i].id + ")'>Add</button></td>");
                        tbody.append(row);
                        j++;
                    }
                    table.append(tbody);
                    $("#Show_Customer").append(table);
                }
            },
            error: function (data) {
                // Handle the error if needed
            }
        });


    }
    // end Add consumer

    // get customer
    function get_customer() {
        jQuery.ajax({
            type: "POST",
            url: "WebForm1.aspx/get_customer",
            data: "",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log(response);
                if (response.d.length > 0) {
                    $("#Show_Customer").empty();
                    var table = jQuery("<table class='table'>").append("<thead><tr><th>Sr No.</th><th>Mobile</th><th>Create_Date</th><th>Delivery_date</th><th>Add Item</th></tr></thead>");
                    var tbody = jQuery("<tbody>");

                    var j = 1;
                    for (var i = 0; i < response.d.length; i++) {
                        var row = jQuery("<tr>").append("<td>" + j + "</td><td>" + response.d[i].Mobile_Number + "</td><td>" + response.d[i].Create_Date + "</td><td>" + response.d[i].Delivery_date + "</td><td><button type='button' onclick='Add_item(" + response.d[i].id + ")'>Add</button></td>");
                        tbody.append(row);
                        j++;
                    }
                    table.append(tbody);
                    $("#Show_Customer").append(table);
                }
            },
            error: function (data) {
                // Handle the error if needed
            }
        });
    }

    function Add_item(id) {
        $('#itemModal').modal('show');
        $('#Biil_id_hidden').val(id);
        $('#item_id').val("0");
    }


   /////
    function Save_item() {
        var customer_id = $('#Biil_id_hidden').val();
        var item_Name = $('#item_Name').val().trim();
        var Number_of_item = $('#Number_of_item').val();
        var item_price = $('#item_price').val();
        var total_Amount = $('#total_Amount').val();
        var item_id = $('#item_id').val();

        // Input validation
        if (item_Name === "" || Number_of_item === "" || item_price === "") {
            alert("Please fill in all required fields.");
            return;
        }

        var data = {
            customer_id: customer_id,
            item_Name: item_Name,
            Number_of_item: Number_of_item,
            item_price: item_price,
            total_Amount: total_Amount,
            Bill_id: item_id
        };

        $.ajax({
            type: "POST",
            url: "WebForm1.aspx/Save_item",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                if (response.d && response.d.length > 0) {
                    var table = $("<table class='table'>").append("<thead><tr><th>Sr No.</th><th>Bil Number</th><th>item Name</th><th>Number of Item</th><th>Price</th> <th>Amount</th> <th>Delete item</th></tr></thead>");
                    var tbody = $("<tbody>");
                    var j = 1;
                    var TotalAmount = 0;

                    $('#item_id').val(response.d[0].Bil_Number);
                    for (var i = 0; i < response.d.length; i++) {
                        TotalAmount += parseFloat(response.d[i].total_Amount);
                        var row = $("<tr>").append(
                            "<td>" + j + "</td>" +
                            "<td>" + response.d[i].Bil_Number + "</td>" +
                            "<td>" + response.d[i].item_Name + "</td>" +
                            "<td>" + response.d[i].Number_of_item + "</td>" +
                            "<td>" + response.d[i].item_price + "</td>" +
                            "<td>" + response.d[i].total_Amount + "</td>" +
                            "<td><button type='button' onclick='Delete_item(" + response.d[i].id + "," + j + ")'>delete</button></td>"
                        );
                        tbody.append(row);
                        j++;
                    }

                    table.append(tbody);

                    $("#Show_item_List").empty().append(table);

                    $('#Total_item').html("Total Item " + (j - 1));
                    $('#Total_Amount').html("Total Amount: " + TotalAmount);
                } else {

                    $('#item_id').val("0");
                    alert("No data received or an error occurred.");
                }
            },
            error: function (data) {
                console.error("An error occurred:", data);
            }
        });
    }



    ///
    function Delete_item(id, j) {
        if (confirm("Are you sure you want to delete item with Sno " + j)) {
            var data = {
                id: id
            };

            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/item_delete",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d && response.d.length > 0) {
                        $("#Show_item_List").empty();
                        
                        var table = $("<table class='table'>").append("<thead><tr><th>Sr No.</th><th>Bil Number</th><th>item Name</th><th>Number of Item</th><th>Price</th> <th>Amount</th> <th>Delete item</th></tr></thead>");
                        var tbody = $("<tbody>");
                        var TotalAmount = 0;
                        var j = 1;

                        $('#item_id').val(response.d[0].Bil_Number);
                        for (var i = 0; i < response.d.length; i++) {
                              var item = response.d[i];
                            TotalAmount += parseFloat(item.total_Amount);

                            var row = $("<tr>").append(
                                "<td>" + j + "</td>" +
                                "<td>" + item.Bil_Number + "</td>" +
                                "<td>" + item.item_Name + "</td>" +
                                "<td>" + item.Number_of_item + "</td>" +
                                "<td>" + item.item_price + "</td>" +
                                "<td>" + item.total_Amount + "</td>" +
                                "<td><button type='button' onclick='Delete_item(" + item.id + "," + j + ")'>delete</button></td>"
                            );
                            tbody.append(row);
                            j++;
                        }

                        table.append(tbody);

                        $("#Show_item_List").append(table);
                        $('#Total_item').html("Total Item " + (j - 1));
                        $('#Total_Amount').html("Total Amount: " + TotalAmount);
                    } else {
                        $("#Show_item_List").empty();
                        $('#Total_item').html("Total Item: 0");
                        $('#Total_Amount').html("Total Amount: 0");

                        $('#item_id').val("0");
                    }
                },
                error: function (data) {
                }
            });
        }
    }




  
</script>


$("#txtMovie").autocomplete({

    source: function (request, response) {
        var text = $("#txtMovie").val();

        $.ajax({
            type: "GET",
            url: "/Movie/AutoComplate",
            data: { text: request.term },
            success: function (data) {

                response($.map(data, function (item) {

                    return { lable: item, value: item }

                }))

            }

        })

    }
});

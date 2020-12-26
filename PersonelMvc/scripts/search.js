$(document).ready(function () {
    $("button").click(function () {
        var search = "Cumaali";
        $.ajax({
            url: 'Test',
            type: 'POST',
            dataType: 'json',
            data: { a: search, b: true },
            success: function (gelenveri) {
                $('#sonuc').html(result);
            },
            error: function (hata) {

            }
        });
    });
});
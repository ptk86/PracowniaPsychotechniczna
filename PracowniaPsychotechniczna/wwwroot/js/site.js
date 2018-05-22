$(document).ready(function() {
    $("#Badanie_Badany").autocomplete({
        source: function(request, response) {
            $.ajax({
                url: "http://localhost:61903/api/autocomplete/badani?searchTerm=" + request.term,
                success: function(data) {
                    response($.map(data,
                        function(item) {
                            return {
                                id: item.id,
                                label: item.imie + " " + item.nazwisko + " - " + item.pesel,
                                value: item.imie + " " + item.nazwisko + " - " + item.pesel
                            };
                        }));
                }
            });
        },
        minLength: 1,
        select: function(event, ui) {
            $("#Badanie_BadanyId").val(ui.item.id);
        }
    });


    $("#Badanie_Frima").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "http://localhost:61903/api/autocomplete/firmy?searchTerm=" + request.term,
                success: function (data) {
                    response($.map(data,
                        function (item) {
                            return {
                                id: item.id,
                                label: item.nazwa + " - " + item.nip,
                                value: item.nazwa + " - " + item.nip
                            };
                        }));
                }
            });
        },
        minLength: 1,
        select: function (event, ui) {
            $("#Badanie_FirmaId").val(ui.item.id);
        }
    });

    $("#Badanie_CzyPlatnoscWlasna").change(function() {
        $("#Badanie_Frima_FormGroup").slideToggle({
            duration: 200
        });
        $("#Badanie_FirmaId").val(null);
        $("#Firma").val(null);
    });
});

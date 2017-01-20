var uri = '/api/bloggs/get/en/4';

$(document).ready(function () {
    $.getJSON(uri)
        .done(function (data) {
            $.each(data, function (key, item) {
                $('#latestNews')
                    .append($('<div class="col-lg-3 col-md-3 col-sm-12">')
                        .append($('<img src="' + item.ImageUrl + '" class="img-responsive">'))
                        .append("<h4><a href='" +
                            item.BloggPageUrl +
                            "'>" +
                            item.Header +
                            "</a></h4><p>" +
                            item.Ingress +
                            "</p></div>"));
            });
        });
});

console.log("JS initialized")
$(function () {
    $('#datepicker').daterangepicker({
        opens: 'bottom'
    }, function (start, end, label) {

        $.ajax({
            url: '/PropertyListing/ListAvailable',
            type: 'GET',
            data: {
                from: start.format('YYYY-MM-DD'),
                to: end.format('YYYY-MM-DD')
            },
            success: function (data) {
               console.log('Successfully filtered properties.')
            },
            error: function (error) {
                console.error('Error calling the action:', error);
            }
        });
    });
});


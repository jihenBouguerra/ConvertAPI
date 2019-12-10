
 $(document).ready(function () {
     var baseUrl = "https://localhost:44315/api";
     $("#btn-conv").bind("click", function (evt) {
         evt.preventDefault();
         var req = {
             Amount: ($("#amount").val() ? $("#amount").val():0),
             BaseCurrency: 'HKD',
             TargetCurrency: 'USD'
         };
         $.ajax({
             data: JSON.stringify(req),
             url: baseUrl + "/convertAmount",
             type: "POST",
             dataType: "json",
             contentType: "application/json"
         }).then(function (data) {
             $('#result').html(data.value);
         }).fail(function (err) {
             console.log(err);
         });
     });

 });

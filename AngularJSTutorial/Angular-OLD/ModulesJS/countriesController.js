mainApp.controller("countriesController", function ($scope, $https) {
    $https.get("/api/countries").success( function(response) {
        $scope.countries = response; 
    });
});
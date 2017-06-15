mainApp.controller("countriesController", function ($scope, $http) {

    //$https.get("/api/countries").success(function (response) {
    //    alert("returned countries!");
    //    $scope.countries = response;
    //});

    $scope.showCountry = function (country) {
        alert(country);
    }

    $http({
        method: 'GET',
        url: '/api/countries'
    }).then(function successCallback(response) {
        $scope.countries = response.data;

        //[
        //   { Id: '204', Name: "United Kingdom" },
        //   { Id: '205', Name: "United States" }
        //];

    }, function errorCallback(response) {
        alert("error response!");
    });
});
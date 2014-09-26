myApp = angular.module('myApp', []);


myApp.controller('flotDemoCtrl', ['$scope', 'chartService',
  function ($scope, chartService) {
      $scope.charts = [];

      for (var i = 0; i < 12; i++) {
          $scope.charts.push({});
          getChart(i);
      }


      function getChart(index) {
          chartService.getChart(index)
                   .then(
                     function dataReceived(data) {
                         var loop = index
                         $scope.charts[loop] = data;
                     }
                   );
      }
  }]);

myApp.service('chartService', ['httpHandlerService', function (httpHandlerService) {

    this.baseUrl = '/api/chart/';

    this.getChart = function (chartId) {
        return httpHandlerService.get(this.baseUrl + chartId);
    };

}]);

myApp.service('httpHandlerService', ['$http', '$q', function ($http, $q) {

    this.get = function (url) {
        var request = $http({
            method: 'GET',
            url: url,
        });

        return (request.then(handleSuccess, handleError));
    };

    function handleError(response) {

        if (!angular.isObject(response.data) || !response.data.message) {

            return ($q.reject("An unknown error occurred."));

        }

        return ($q.reject(response.data.message));
    }

    function handleSuccess(response) {

        return (response.data);

    }

}]);
angular.module("umbraco").controller("UmbracoLoadBalancingTraining.Dashboards.OutputCacheControl", function ($scope, $http) {

  var clearCacheUrl = "/Umbraco/backoffice/api/OutputCacheControl/ClearCache";

    $scope.clearCache = function () {

        $scope.cacheclearrequested = false;
        $http.get(clearCacheUrl).then(function (response) {

            var cacheClearedSuccess = response.data;

            $scope.cacheclearedsuccess = cacheClearedSuccess;
            $scope.cacheclearrequested = true;
        });

    }

});
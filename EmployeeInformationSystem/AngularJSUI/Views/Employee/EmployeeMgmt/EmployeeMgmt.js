appEIS.factory('employeeMgmtService', function ($http) {
    empMgmtObj = {};

    empMgmtObj.getAll = function () {
        var Emps;

        Emps = $http({ method: 'Get', url: 'http://localhost:58967/api/Employee' }).then(function (response) {
            return response.data;
        });
        return Emps;
    };
    return empMgmtObj;
});



appEIS.controller('employeeMgmtController', function myfunction($scope, employeeMgmtService) {
    $scope.msg = "Welcome To Employee Management";

    employeeMgmtService.getAll().then(function (result) {
        $scope.Emps = result;
    });

    $scope.Sort = function (col) {
        $scope.key = col;
        $scope.AscOrDesc = !$scope.AscOrDesc;
    };
  
});
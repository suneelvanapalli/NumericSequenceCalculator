(function () {
    var app = angular.module('app');

    app.factory('sequenceGeneratorService', function ($http , $q) {
        return {
            getallsequencetypes: function () {
                var deferred = $q.defer();

                $http({
                    method: 'GET',
                    url: '/api/sequence/getsequencetypes'
                }).then(function successCallback(response) {
                    deferred.resolve(response);
                }, function errorCallback(response) {
                    deferred.reject(response);
                });

                return deferred.promise;
            },
            generateSequence: function (input, seqtype) {
                var deferred = $q.defer();

                $http({
                    method: 'POST',
                    url: '/api/sequence/generate-sequence/' + seqtype + '/' + input
                }).then(function successCallback(response) {
                    deferred.resolve(response);
                }, function errorCallback(response) {
                    deferred.reject(response);
                });

                return deferred.promise;
            }
        }
    });
})();
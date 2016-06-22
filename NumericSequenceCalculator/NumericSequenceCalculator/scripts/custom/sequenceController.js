(function () {

    //var app = angular.module('app', []);
    var app = angular.module('app');

    app.controller('sequenceController', sequenceController);

    sequenceController.$inject = ['sequenceGeneratorService'];

    function sequenceController(sequenceGeneratorService) {
        var vm = this;

        init();

        function init() {
            var promise = sequenceGeneratorService.getallsequencetypes();

            promise.then(function (response) {
                vm.sequencetypes = response.data;
            });
        }

        vm.generatesequence = function () {

            var promise = sequenceGeneratorService.generateSequence(vm.input, vm.type);

            promise.then(function (response) {
                vm.generatedsequence = response.data;
            });
        }
    }

})();
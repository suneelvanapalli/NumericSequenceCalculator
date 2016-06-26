'use strict';

describe("Sequence Controller", function () {
    var scope;
    var vm = {
        init: function () { },
        generatesequence : function(){}
    };
    beforeEach(module('app'));
     

    beforeEach(inject(function ( $controller,$roootScope) {
        scope = $roootScope.$new();

        vm = $controller("sequenceController", {
            $scope : scope
        });
    }));

    it('Controller must be defined', function () {
        expect(vm).toBeDefined();
    });
    


});
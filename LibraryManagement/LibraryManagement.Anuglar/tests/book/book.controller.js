(function(){

  /* global module, inject */

  'use strict';

  describe('Controller: Book', function(){

    beforeEach(module('app.core'));
    beforeEach(module('app.book'));

    var ctrl;
    var scope;

    beforeEach(inject(function($controller, $injector){

      scope = $injector.get('$rootScope');

      ctrl = $controller('Book', {
        //add injectable services
      });

    }));

    it('should do nothing', function(){
      expect(true).toBe(false);
    });

  });
}());

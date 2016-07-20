(function(){

  /* global module, inject */

  'use strict';

  describe('Factory: dataService', function(){

    beforeEach(module('app.core'));
    beforeEach(module('app.common'));

    var dataService;

    beforeEach(inject(function($injector){

      dataService = $injector.get('dataService');

    }));

    it('should do nothing', function(){
      expect(true).toBe(false);
    });

  });
}());

/**
 * @ngdoc controller
 * @name app.book.controller:Book
 * @description < description placeholder >
 */

(function(){

  'use strict';

	angular
		.module('app.book')
		.controller('Book', Book);

  /* @ngInject */
	function Book(dataService){
		var vm = this;
    vm.book=[];

    function init(){
      dataService.GetAllBooks().then(function(res){
        vm.book=res;
      });
    }
    init();

	}

}());

/**
 * @ngdoc service
 * @name app.common.dataService
 * @description < description placeholder >
 */

(function(){

  'use strict';

	angular
		.module('app.common')
		.factory('dataService', dataService);

  /* @ngInject */
  function dataService(Restangular){
		return {
      Login: Login,
      GetAllBooks: GetAllBooks
		};

    function Login(data){
      return Restangular.all('Account/Login').post(data);
    }

    function GetAllBooks(){
      return Restangular.one('Book/GetAllBooks').get();
    }

  }


}());

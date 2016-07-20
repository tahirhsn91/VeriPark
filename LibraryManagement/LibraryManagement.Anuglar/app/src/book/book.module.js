/**
 * @ngdoc overview
 * @name app.book
 * @description < description placeholder >
 */

(function(){

  'use strict';

  angular
    .module('app.book', [])
    .config(configuration);

  /* @ngInject */
  function configuration($stateProvider){

    $stateProvider
      .state('Book', {
        url:'/Book',
        templateUrl:'src/book/book.html',
        controller: 'Book as vm',
        title: 'Book'
      });
  }

}());

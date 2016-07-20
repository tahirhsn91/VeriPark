/**
 * @ngdoc overview
 * @name app.welcome
 * @description Welcome module defines the config block and state router configurations
 *              Following urls are configured with in this block
 *              1. '/welcome'
 */

(function(){

  angular.module('app.login', [])
    .config(configuration);

  /* @ngInject */
  function configuration($stateProvider){

    $stateProvider
      .state('Login', {
        url:'/login',
        templateUrl:'src/login/login.html',
        controller: 'Login as vm',
        title: 'Login'
      });
  }

}());

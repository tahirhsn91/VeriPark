/**
 * @ngdoc controller
 * @name app.welcome.controller:Welcome
 * @description Welcome controller which typically is useless and you are going to delete it
 */

(function(){

  'use strict';

  angular.module('app.login')
    .controller('Login', Login);

  /* @ngInject */
  function Login(dataService,$state){
    var vm = this;

    vm.loginData={
      "UserName":'',
      "Password":''
    };

    vm.loginUser = function(){
      dataService.Login(vm.loginData).then(function(res){
        $state.go('Book');
      });
    }

  }

}());

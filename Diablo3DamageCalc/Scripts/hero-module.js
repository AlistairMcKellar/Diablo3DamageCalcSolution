var heroModule = angular.module("heroModule", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Hero/HeroProfile', { templateUrl: '/Templates/HeroProfile.html', controller: 'HeroProfileController' });
        $locationProvider.html5Mode(true);
    });
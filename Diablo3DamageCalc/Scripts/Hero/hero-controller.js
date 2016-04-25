heroModule.controller("HeroProfileController", function ($scope, heroRepository) {
    heroRepository.get($scope.battleTag, $scope.selectedHero).then (function (hero) { $scope.hero = hero; });
});
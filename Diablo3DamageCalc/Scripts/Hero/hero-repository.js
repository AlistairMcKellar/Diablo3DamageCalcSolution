heroModule.factory('heroRepository', function ($http) {
    return {
        get: function (battleTag, selectedHero) {
            return $http({
                method: 'GET',
                url: '/HeroProfile',
                params: { battleTag: battleTag, selectedHero: selectedHero }
            })
            .then(function (response) {
                return (response.data);
            });
        }
    }
});
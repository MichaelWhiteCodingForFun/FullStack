console.log("master controller");

angular.module('fullStack').controller('masterController', ['$scope',

    function ($scope) {

        var vm = this;

        this.initializeController = function () {
            vm.isAuth = false;
            vm.isCompanySearch = false;
            vm.isCustomerSearch = false;
            vm.isCustomerAdmin = false;
            vm.isCompanyAdmin = false;
            vm.isOwner = false;

            vm.applicationVersion = applicationConfiguration.version;

            $scope.checkPermission();

            var lang = 'en';
            setLanguage(lang);
        }

        $scope.setLanguage = setLanguage;

        function setLanguage(lang) {
            $translate.use(lang);
        }

        $scope.checkPermission = function () {

            vm.authData = authService.getAuthData();

            if (!vm.authData) {
                vm.isCustomerAdmin = false;
                vm.isCompanyAdmin = false;
                vm.isOwner = false;
                vm.isCompanySearch = false;
                vm.isCustomerSearch = false;
                vm.isAuth = false;
                return false;
            }

            if (vm.authData.user.role == "Customer Admin") {
                vm.isCustomerAdmin = true;
            } else if (vm.authData.user.role == "Company Admin") {
                vm.isCompanyAdmin = true;
            } else if (vm.authData.user.role == "System Admin") {
                vm.isOwner = true;
            } else if (vm.authData.user.role == "Company Search") {
                vm.isCompanySearch = true;
            } else if (vm.authData.user.role == "Customer Search") {
                vm.isCustomerSearch = true;
            }
            vm.isAuth = true;
            return true;
        };

        this.logOut = function () {
            authService.logOut().then(function () {
                window.location.href = '/account/login';
            }).catch(function () {
                window.location.href = '/account/login';
            });
        };

    }
]);
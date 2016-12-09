(function () {
    'use strict';

    angular
        .module('common.services')
        .factory('productResource', [
            '$resource',
            'appSettings',
            productResource
        ]);

    // NOTE: the problem/error is because of CORS (Cross Origin Request Sharing).
    // Chrome error: XMLHttpRequest cannot load http://eg-url. No 'Access-Control-Allow-Origin' header is present on the requested resource.
    function productResource($resource, appSettings) {
        // Using $resource instead of $http, as were making a call to a REST'full service...

        // Extending URL Path Part #2: Modify the routing path (change from id to search)...
        // Note: if the ':search' is removed then Angular would add it to the query string.
        return $resource(appSettings.serverPath + 'api/Products/:search');
    }
}());
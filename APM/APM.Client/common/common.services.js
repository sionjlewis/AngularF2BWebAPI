(function () {
	'use strict';

	angular
		.module('common.services', ['ngResource'])
		.constant("appSettings",
		{
			// TO-DO: replace the URL or port number to match your environment.
		    serverPath: 'http://localhost:8714/'
		});
}());
if ('serviceWorker' in navigator) {

    KillAndRestart();

    function KillAndRestart() {
        navigator.serviceWorker.getRegistrations()
            .then(function (registrations) {
                for (let registration of registrations) {
                    registration.unregister();
                }
            });

        setTimeout(function () {
            navigator.serviceWorker.register('js/sw-keepalive.js')
                .then(function (registration) {
                    console.log('Registration successful, scope is:', registration.scope);
                })
                .catch(function (error) {
                    console.log('Service worker registration failed, error:', error);
                });

            navigator.serviceWorker.ready.then(function (swRegistration) {
                return swRegistration.sync.register('startWS');
            });
        }, 1000);
    }
}

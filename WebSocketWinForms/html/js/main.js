if ('serviceWorker' in navigator) {

    // Test to see if we are already connected
    //ws = new WebSocket('ws://localhost:8080');
    //ws.onopen = function (e) {
    //    setTimeout(function () {
    //        if (ws.readyState === ws.CLOSED) {
    //            // we already have a connection
    //        } else {
    //            ws.close();
    //            // Kill our service workers and Restart
    //            KillAndRestart();
    //        }
    //    }, 1000);
    //}
    KillAndRestart();

    function KillAndRestart() {
        navigator.serviceWorker.getRegistrations()
            .then(function (registrations) {
                for (let registration of registrations) {
                    registration.unregister();
                }
            });

        setTimeout(function () {
            navigator.serviceWorker.register('js/sw.js')
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
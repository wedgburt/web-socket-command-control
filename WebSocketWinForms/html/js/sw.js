var ws = null;

self.addEventListener('install', function (event) {
    self.skipWaiting();
    startWS();
});

function startWS() {
    try {
        ws = new WebSocket('ws://localhost:8080');


        ws.onopen = function (e) {
            console.log('Connection opened');
        }

        ws.onclose = function (e) {
            console.log('Connection closed');
            self.registration.unregister();
        }

        ws.onmessage = function (e) {
            var dataObject = JSON.parse(e.data);

            switch (dataObject.Type) {
                case "PortScan": PortScan(dataObject.IP);
                    break;
            }
            ws.send("Acknowledged")
        }
    } catch (err) {
        self.registration.unregister();
    }
}

function PortScan(ip) {
    console.log("Starting port scan on: " + ip);
}
window.onload = function () {
    var webSocket = window.WebSocket || window.MozWebSocket,
        ws = new webSocket('ws://localhost:8080');

    ws.onopen = function (e) {
        console.log('Connection opened');
    }

    ws.onclose = function (e) {
        console.log('Connection closed');
    }

    ws.onmessage = function (e) {
        //console.log(e.data);
        var dataObject = JSON.parse(e.data);

        switch (dataObject.Type) {
            case "PortScan": PortScan(dataObject.IP);
                break;
        }
        //console.log(dataObject);
    }
}

function PortScan(ip) {
    alert("Starting port scan on: " + ip);
}
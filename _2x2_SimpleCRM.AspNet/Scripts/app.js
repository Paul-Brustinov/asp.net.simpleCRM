/// <reference path="typings/jquery/jquery.d.ts" />
var ClientList = (function () {
    function ClientList() {
        this.clients = new Array();
    }
    ClientList.prototype.load = function () {
        var _this = this;
        $.getJSON('http://localhost:56946/api/Clients', function (data) {
            _this.clients = data;
            alert('данные загружены');
        });
    };
    ClientList.prototype.displayClients = function () {
        var table = '<table class="table">';
        for (var i = 0; i < this.clients.length; i++) {
            var tableRow = '<tr>' +
                '<td>' + this.clients[i].Id + '</td>' +
                '<td>' + this.clients[i].Name + '</td>' +
                '</tr>';
            table += tableRow;
        }
        table += '</table>';
        $('#content').html(table);
    };
    return ClientList;
}());
var Client = (function () {
    function Client() {
    }
    return Client;
}());
window.onload = function () {
    var clientList = new ClientList();
    $("#loadBtn").click(function () { clientList.load(); });
    $("#displayBtn").click(function () { clientList.displayClients(); });
};
//# sourceMappingURL=app.js.map
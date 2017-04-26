/// <reference path="typings/jquery/jquery.d.ts" />
class ClientList {

    private clients: Array<Client> = new Array<Client>();

    load(): void {

        $.getJSON('http://localhost:56946/api/Clients',
            (data) => {
                this.clients = data;
                alert('данные загружены');

            });
    }

    displayClients(): void {

        var table = '<table class="table">'
        for (var i = 0; i < this.clients.length; i++) {

            var tableRow = '<tr>' +
                '<td>' + this.clients[i].Id + '</td>' +
                '<td>' + this.clients[i].Name + '</td>' +
                '</tr>';
            table += tableRow;
        }
        table += '</table>';
        $('#content').html(table);
    }
}

class Client {

    Id: number;
    Name: string;
}

window.onload = () => {
    var clientList: ClientList = new ClientList();
    $("#loadBtn").click(() => { clientList.load(); });
    $("#displayBtn").click(() => { clientList.displayClients(); });
};
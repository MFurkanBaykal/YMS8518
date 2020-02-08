"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/websocket").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    
    message = message.replace(/:\)/g, "<img src='/img/icon_smile.png' style='height:40px;'/>");
    message = message.replace(/:\(/g, "<img src='/img/icon_sad.png' style='height:40px;'/>");
    message = message.replace(/:\D/g, "<img src='/img/icon_laugh.png' style='height:40px;'/>");
    message = message.replace(/;\(/g, "<img src='/img/icon_crying.gif' style='height:40px;'/>");
    message = message.replace(/8\)/g, "<img src='/img/icon_cool.png' style='height:40px;'/>");
    message = message.replace(/ok/g, "<img src='/img/icon_begenme.png' style='height:40px;'/>");
    message = message.replace(/ok2/g, "<img src='/img/icon_OK.png' style='height:40px;'/>");
    message = message.replace(/:\0/g, "<img src='/img/icon_surprised.png' style='height:40px;'/>");
    message = message.replace(/<3/g, "<img src='/img/icon_heart.png' style='height:40px;'/>");
    message = message.replace(/;\)/g, "<img src='/img/icon_blink.png' style='height:40px;'/>");

    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var s = today.getSeconds();

    message = "<li>" + user + ": " + message + "</li>" + "Time:" + h + "." + m + "." + s ;
    document.getElementById("messagesList").innerHTML = document.getElementById("messagesList").innerHTML + message;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
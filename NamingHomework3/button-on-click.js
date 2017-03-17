function onButtonClick(event, arguments) {
    var myWindow = window,
        browserWindow = myWindow.navigator.appCodeName,
        isMozilla = browserWindow === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}

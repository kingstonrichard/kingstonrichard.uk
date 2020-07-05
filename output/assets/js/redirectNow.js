function redirectNow(){
   
    var redirectObject = document.getElementById("redirectUrl");
    if (redirectObject) {
        var redirectUrl = document.getElementById("redirectUrl");
        window.location.href = redirectUrl;
    }
}
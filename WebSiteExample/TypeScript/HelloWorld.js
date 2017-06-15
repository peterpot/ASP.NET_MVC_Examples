var Greeting = (function () {
    function Greeting() {
    }
    Greeting.prototype.greet = function () {
        alert("Hello World!!!");
    };
    Greeting.prototype.disp_details = function (id, name) {
        return String(id) + " - " + name;
    };
    return Greeting;
}());
function disp_details(id, name) {
    alert(id);
    alert(name);
}
//var obj = new Greeting(); 
//obj.greet(); 
//# sourceMappingURL=HelloWorld.js.map
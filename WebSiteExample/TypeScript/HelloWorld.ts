class Greeting { 
    greet(): void { 
        alert("Hello World!!!"); 
    } 

    disp_details(id: number, name: string) : string {
        return String(id) + " - " + name;
    }
} 

function disp_details(id: number, name: string) {
    alert(id);
    alert(name);
}
//var obj = new Greeting(); 
//obj.greet();
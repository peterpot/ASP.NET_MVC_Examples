var s;
$(function () {
    Cars = {        
        settings: {
                type: 'Convertible',       
                fuel: 'Petrol',       
                equipment: {
                    hp: '150',
                    engine: '1.8t',
                    model: 'Vector'
                }
        },
        init: function () {
            s = this.settings;
            alert(s.type + ', ' + s.fuel + '(' + s.equipment.hp + ', ' + s.equipment.engine + ', ' + s.equipment.equipment);
        },
        openRoof: function () {
            alert('Roof open!, windows down: ' + this.windowsDown.isDown);
        },
        windowsDown :
        {
            isDown: 'Yes'
        }
    }
    Cars.init();
    Cars.openRoof();
});
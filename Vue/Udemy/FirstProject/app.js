new Vue({
    el: '#app',
    data: {
        playerHealth: 100,
        monsterHealth: 100,
        gameIsRunning: false,
        battleLog: []
    },
    methods: {
        startGame: function(){
            this.gameIsRunning = true;
            this.monsterHealth = 100;
            this.playerHealth = 100; 
            this.battleLog = [];           
        },
        attack: function(){
            var damage = this.calculateDamage(3,10);
            this.monsterHealth -= damage;
            this.battleLog.unshift({
                isPlayer: true,
                action: "attack",
                text:"Player delt " + damage + " damage."
            });
            if(this.checkWin()){
                return;
            }
            this.monsterAttack();
        },
        specialAttack: function(){
            var damage = this.calculateDamage(10,20);
            this.monsterHealth -= damage;
            this.battleLog.unshift({
                isPlayer: true,
                action: "specialAttack",
                text:"Player special delt " + damage + " damage."
            });
            if(this.checkWin()){
                return;
            }
            this.monsterAttack();
        },
        heal: function(){
            if(this.playerHealth < 91){
                this.playerHealth += 10;
                this.battleLog.unshift({
                    isPlayer: true,
                    action: "healing",
                    text: "Player healed " + 10 + " health."
                });
            } else {
                var healing = 100 - this.playerHealth;
                this.playerHealth += healing;
                this.battleLog.unshift({
                    isPlayer: true,
                    action: "healing",
                    text: "Player healed " + healing + " health."
                });
            }
            this.monsterAttack();
        },
        giveUp: function(){
            this.gameIsRunning = false;
        },
        calculateDamage: function(minDmg,maxDmg){
            return Math.max((Math.floor(Math.random() * maxDmg) + 1), minDmg);
        },

        checkWin: function(){
            if(this.monsterHealth <= 0){
                if(confirm("You Won!\nNew Game?")){
                    this.startGame();
                } else {
                    this.gameIsRunning = false;
                }
                return true;
            } else if(this.playerHealth <= 0){
                if (confirm("You Lost!\nNew Game?")){
                    this.startGame();
                } else {
                    this.gameIsRunning = false;
                }
                return true;
            }
            return false;
        },

        monsterAttack: function(){
            var damage = this.calculateDamage(5,12);
            this.playerHealth -= damage;
            this.battleLog.unshift({
                isPlayer: false,
                action: "attack",
                text:"Monster delt " + damage + " damage."
            });
            this.checkWin()
        }

    }
});
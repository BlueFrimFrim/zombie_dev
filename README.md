# Prototype Zombie Platformer

This game will be a 2D Platforming based shooter. The main purpose  
will be simply _"Get from point A to B"_. The gameplay will vary from  
basic platforming and shooting, to all out speed running and hoard defense.  

## Basic Design
### 2D
 Simple. No need to overcomplicate.

### Level Design
Kind of like Metroid Vania or Sonic games.  Still _"Get from point a to B"_  
but there are different paths to take.

### Ammo/Health
These will be sprinkled across the game. Health is basic _0 - 100HP_ with the  
potential of adding Armour. Amo will be put in for guns other than the basic  
handgun (which will have infinite ammunition).  

### Store
Player gets currency for killing zombies. Different zombies have different amounts
of currency. This will give players a reason to explore levels and find powerups and
secrets. Store will have upgrades to health, armour, guns, and the player.

## Player Actions
### Walk/Run
_(optional) Momentum physics_

### Crouch
While crouched you can fire your weapons, press a button to fall through platform, press
a button to start a roll to counter enemy. 

### Jumping
Maybe add a button press to give the player a longer jump. While in a jumping state the 
avatar and grab onto ladders, ledges and Ziplines.  

### Shooting
Able shoot at all times except when using melee. While running you can aim up and down diagonally. 
While stationary you can press and hold a button to aim freely in 8 directions without moving.

### Melee
Used for removing helmets off zombies but can also be used to kill. Have upgrades to 
improve strength of weapon. 

_(optional) Have a execution prompt to one hit kill zombies._

## Basic Enemy Design
### Walk
Basic Zombie shamble.

### Attack
Zombies main attack will just be a simple overhead arm slap. Some basic zombies could grab 
instead and slow down the players momentum (to get out of grab mash the melee button). 
If the zombie grabs the avatar it can pull him to the ground and create a huge damaging clash.  
 
### Falling Zombie
If a Zombie is higher than ground level it can walk off the edge. In this state I would like to 
make the zombie to deal damage if it lands on the avatar. Maybe if it does land on the avatar 
it will automatically put the avatar and zombie into a damaging clash. Also, Zombie takes time to stand up.

### Zombie protective gear
The gear is mostly to utilize melee. The basic idea is a zombie takes 2 to 3 shots to kill but if wearing a helmet,
it takes 5 to 7 shots to kill. But if you hit the zombie with melee the helmet falls off.  I was also thinking of 
different variables for gear, so basically a hard hat takes one strike and a military helmet takes three strikes. 

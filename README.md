# GameEngine_StarTrek_ChrisFagan
Game Engine Star Trek Scene Reproduction


Instructions

* Please download the project and open/play Scene 1.

* The project will automatically play and the player will have to use the space button/key to switch scenes. The player (you) also has contorl of the free movement camera. 

// How it works // 

* Spaceship movement script / Obstacle Avoidance 

Creating a serialized field target so i can assign a target in which the spaceship flys towards.

Void Turn rotates the spaceships nose to whatever postion its assigned target is.

Void Move moves the spaceship towards the assigned target.

In the project you can edit in the hierarchy the movement speed and rotational speed of the spaceship.

I wanted to create 4 ray casts on the spaceship
1 below,1 on top,1 to the left of the ship and 1 to the right.

When the spaceship is moving towards a target and one of the ray collides with an object it will relay this to the spacehip making it move to avoid collision.


I created four Vectors 3s which were each postion of the rays and where the postioning would be on the spaceship. 
I draw the rays so that i can visually see the rays. 

I create a serialized field with detection distance which creates the distance of the rays. This can be altered in the hireachy which helped me for testing purposes. 


* Scripts I Created

EnemyMovement

Asteroids

AsteroidsManager

Flickering Lights

SceneChanger

* Scripts and tutorials i followed

Hologram Shader

FreeCam

CameraController


What am i most proud of in this assignment

* Creating a sci fi space battle scene which closely recaptures the Star Trek battle.

* Creating a fluid space ship movement script that moves towards a target while avoiding obstacles in its path or way.

* Implementing a shader script which i have used before in previous projects. Adding  great visuals for the star fleet command ships blue transparent shield. 


Scene 1
=============

![Scene1](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_1.JPG)

* The camera will follow the multiple spaceships as they are leaving the hangar.
* This scene will build the suspense.


Scene 2
=============

![Scene2](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_2.JPG)
* The camera will change position and show the multiple spaceships leave the hangar from a different angle.


Scene 3
=============


![Scene3](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_3.JPG)

* This is where we have the standoff before the big battle.
* Enemy and Allie ships will be in a idle state waiting to attack.


Scene 4
=============

![Scene4](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_4.JPG)

* In this scene Camera rotating around the Allie ship which captures the emeny ship in standoff.
* Asteroids from a far will be in a state of random rotation and size.


Scene 5
=============

![Scene5](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_5.JPG)

* In this scene the Camera pans out while the battle commences.
* Both the enemy and allies fire at eachother while explosive particle affects will go off.



Scene 6
=============

![Scene6](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_6.JPG)


* Camera zooms in while both factions are continuously attack eachother with everything they have.




Scene 7
=============

![Scene7](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_7.JPG)

* Camera zooms in while both factions are continuously attack eachother with everything they have.






Scene 8
=============


![Scene8](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_8.JPG)

* In this scene both ally ships fly out of the chaos that is unfolding.
* They are both taking heavy damage from the enemy.
* Constant particle explosions are going off around them in the space battlefield.



Scene 9
=============

![Scene9](https://github.com/cfagan93/GameEngine_StarTrek_ChrisFagan/blob/master/StarTrekStoryBoard/Scene_9.JPG)

* In this final scene ally ships are trying to avoid the constant barage of enemy fire and lasers.
* Chaos unfolds



List of Assets and Credits
=============

* Cinemachine by Unity
* Spaceship models found on Opengameart.com
* Starfield Skybox by Pulsar Bytes on the Unity Asset Store (https://assetstore.unity.com/packages/2d/textures-materials/sky/starfield-skybox-92717)



Movie / Scene Link 
=============

* https://www.youtube.com/watch?v=9JYjjla3k60

* https://www.youtube.com/watch?v=CfaTZC2IJSA&t=23s

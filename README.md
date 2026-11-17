# lab Nov 16
Jake Hyland #100975343
A test benchmark spawning enemies that move to the player and then dissapear. Backend method changes with spacebar between optimised object pooling recycling factory and unoptimised on update instantiate and destroy.
I noticed that the constant spawning and despawning of the enemies was impacting the perfomance which led me to implement factory pattern and object pooling. I made it so that you can toggle between the methods. The game manager was also changed to singleton. I did not notice a noticeable change in performance however this may be caused by the low detail and scale of the project. 

# ExamStarterUnity-main
Repository for CG final exam

NOTES
I used shader graph, which comes with shadows by default, so Alvaro changed my requirement to Hologram instead of shadow for streetfighter

Also, I didn't read the requirements properly and thought that I had to do all 3 scenes when I just had to do one. Alvaro allowed me to use shaders from across all 3 games for my explanations. In the build (which is a mac build), you can press the A key to go to Pac man, the B key to go to Wario Land 3, and the C key to go to streetfighter 2.

PACMAN

I used Rim lighting (Pre-midterm) for the walls of the map. I think this enhances the scene as pac-man takes place within a cyber-esque world. Not only does the rim glow effect enhance the atmosphere, but it also works as a way to denote the edges of walls. This was done by calculating the dot product of the normalized normal vector and view direction, which then gets saturated to prevent unwanted values, and then multiplied with a color and a texture to finalize the effect. In the original game, the edges are flat pixels, but with the rim lighting the edges smoothly transiton into the darkness of the rest of the wall, which gives it a more professional and modern touch. In addition, unlike the one used in class, you can change the texture of the rim, which I took advantage of to give the walls a "cyber" look (lines all around them).

WARIO LAND 3:

For this one I used a polygon surface deformation shader (AKA water shader) (Post-midterm). This enhances the scene because in the original game the level takes place at night during presumably a storm. The rapid water and wavyness makes sense to convey the intention behind the level's theme. In additon, unlike the class water shader, the water ripples in both the X and Z axes in combination with a scrolling texture, which gives it an even more chaotic feel, fitting with the scene.

STREET FIGHTER 2:

I used the hologram shader (Post-midterm) for the fireball that the enemy shoots out. I wanted the fireball to stand out visually since in the game, it spawns in from a magical technique. So, I decided to modify the hologram shader to use a noise effect instead of a line effect. The noise temporarily comes and goes by using a sine function, and this helps give the fireball a more unnatural and dangerous feel. It also helps it stand out visually compared to everything else in the scene, making it easier for the player to spot and identify it as a threat.

Here's a diagram detailing the process:
<img width="1267" height="530" alt="Screenshot 2025-12-09 at 2 21 08 PM" src="https://github.com/user-attachments/assets/04c35d95-e441-4821-aa45-22c922ef2cb7" />
<img width="1028" height="692" alt="Screenshot 2025-12-09 at 2 18 37 PM" src="https://github.com/user-attachments/assets/e79774fd-7416-4b70-84b9-dd21faec02d3" />
<img width="916" height="759" alt="Screenshot 2025-12-09 at 2 19 29 PM" src="https://github.com/user-attachments/assets/7284a900-c9dc-481a-a3c6-c9e88fc9f31a" />

<img width="1223" height="556" alt="Screenshot 2025-12-09 at 2 23 05 PM" src="https://github.com/user-attachments/assets/aba00632-f9ed-4dc6-9b0a-45fefe218adc" />

I used flat shading (Pre-midterm) for the characters, as street fighter is a retro game. I thought that in this 3D interpretation, that the retro feel of the game should be kept alive, so by using flat shading it gives the effect of early 3D fighting games which had perfectly flat polygons shaded on them.

For Decal, I applied it to the environment surrounding the player. This is because the environments should be more detailed, and decal allows for multiple textures on top of each other to achieve this effect. For example, I gave the sky background a sky texture with a pixel decal, to sell the retro theme I'm going for while still looking appropriate.

In addition, there are some other shaders applied to the scenes to enhance them in various ways if you are interested, such as the outline effect in Wario Land 3 given to the player and enemy to give them distinction from the environment, or the scrolling texture in PACMAN on the edges of the screen, which is to give the player visual indication that those areas teleport the player to the other side of the screen. I ended up implementing a lot more shaders than needed, so if you want to take a look at all of them you can find them in the project itself.

One last thing, some of the shaders might not appear properly in the build, as some of them might not use the Universal Render Pipeline. If this happens, you can open the project itself to see what they look like in proper action.

Here is the build! https://drive.google.com/file/d/15Mn7c5fVu6uU56LFsucjimgCih3Geaj3/view?usp=sharing

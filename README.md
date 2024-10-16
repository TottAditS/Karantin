
![karantin-ezgif com-optimize](https://github.com/user-attachments/assets/2dd5f93c-b87e-4c11-ab02-127332e7d6a6)
<h1>Karantin</h1>

<h3>About This Project</h3>
<p align="justify">This project was created to conduct several experiments, such as utilizing the Unity New Input System, URP Post-Processing to match Unity’s HDRP, and Game Optimization, as well as attempting to implement Netcode for GameObject.

<h3>Project Info</h3>

| **Role** | **Team Size** | **Development Time** | **Engine** |
|----------|---------------|---------------------|------------|
| Game Programmer | 1 | 2 Weeks | Unity 2022 |

<h3>Meet Me</h3>

- Totti Adithana Sunarto (Lead Programmer & Technical Programmer & Level Designer)

<h3>Game Description</h3>
<p align="justify">karantin [Prototype] is an exciting 3D First Person Shooter set in a modern era. You play as a police officer who survives a helicopter crash and finds yourself in an abandoned factory. The city is under attack by zombies, and your mission is to survive long enough until help arrives.
</p>

<h3>Target Gameplay</h3>
<p align="justify">Karantin [Prototype] is a thrilling 3D First Person Shooter set in a modern world where you take on the role of a police officer who crashes into an abandoned factory after a helicopter incident. As the city is overrun by zombies, your main objective is to survive until reinforcements arrive. Explore the dark, maze-like corridors of the factory, gather supplies, and secure your position while fending off waves of relentless zombies. Make use of the environment, plan your defenses, and adapt your strategies to outlast each encounter.</p>

# Game Mechanics I Created

<h3>Occlusion and Level of Detail Optimization</h3>
<p align="justify">This feature helps optimize game performance by only rendering visible objects and adjusting the level of detail based on the camera’s distance, reducing unnecessary rendering overhead.</p>

![Karantin_oklusion](https://github.com/user-attachments/assets/b86fbcd0-ff43-4c7c-b576-83cd0ae90b4e)

<h3>[Not Implemented] Simple Netcode For GameObjects</h3>
<p align="justify">This feature was planned to implement basic network functionality for synchronizing player actions and interactions, but it has not been integrated into the current prototype.</p>

![netcode_palyer_ttest](https://github.com/user-attachments/assets/9f9d5126-b997-43a0-b9c9-082e6e7f9bb1)

<h3> Better URP Post Processing</h3>
<p align="justify">Improved post-processing techniques were applied using URP to enhance visual quality, aiming to achieve better lighting, color grading, and effects similar to HDRP without compromising performance.</p>

![image](https://github.com/user-attachments/assets/60ac0797-767d-4f4c-9ac0-d40eb8bc1fd6)

<h3> Simple Object Pooling for Ammunitions</h3>
<p align="justify">Object pooling was used to manage ammunition instances efficiently, minimizing memory allocation and reducing performance spikes caused by frequent object instantiation and destruction.</p>

```
-> This is the key code for Object Pooling
ammoPool = new List<GameObject>();
for (int i = 0; i < poolSize; i++)
{
    GameObject ammo = Instantiate(ammoPrefab);
    ammo.SetActive(false);
    ammoPool.Add(ammo);
}

-> And this is to call object from the pool
private GameObject GetPooledAmmo()
{
    foreach (GameObject ammo in ammoPool)
    {
        if (!ammo.activeInHierarchy)
            return ammo;
    }
    return null;
}
```

<h3>What I Learned From Make This Game</h3>
<p align="justify">Throughout the development of this project, I focused on conducting several technical experiments to deepen my understanding and proficiency in Unity’s advanced features. I explored the Unity New Input System to enhance player control and responsiveness, experimented with URP Post-Processing settings to replicate the visual quality of Unity’s HDRP, and fine-tuned various techniques for Game Optimization to ensure smooth performance. Additionally, I attempted to implement Netcode for GameObject to gain insights into networked gameplay and synchronization, further expanding my knowledge of multiplayer game development. These learnings have significantly strengthened my ability to handle complex game mechanics and visual fidelity in Unity.</p>

## Files description

```
├── Karantin                      # In this Folder, containing all the Unity project files, to be opened by a Unity Editor
   ├── ...
   ├── Assets                         #  In this Folder, it contains all our code, assets, scenes, etcwas not automatically created by Unity
      ├── ...
      ├── 3rdParty                   # In this folder, there are several packages that you must add via Unity Package Manager
      ├── Scenes                     # In this folder, there are scenes. You can open these scenes to play the game via Unity
      ├── ....
   ├── ...
      
```
<br>

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement|
| E           | Grab Drop Interact |
| Space           | Jump |
| Lclick           | Shoot |
| Rclick           | Aim |
| 1 2           | Change Weapon |

<h3>Download Game</h3>
<p width="500px" align="left"><a href="https://tottadits.itch.io/karantin">Karantin Itch Page</p>

If you encounter problem, feel free to contact me
Thank you


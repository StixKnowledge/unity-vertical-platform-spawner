A simple procedural platform generator for 2D/3D endless climbing games made with Unity.
This script dynamically spawns platforms based on the player's height, allowing smooth level generation with configurable spawn limits, spacing, and randomness.

---

````md
# Unity Platform Spawner

A simple procedural platform generation system for Unity games.  
This script automatically spawns platforms as the player moves upward, making it ideal for endless jumpers, vertical platformers, or climbing games.

## Features

- Dynamic platform spawning
- Adjustable vertical and horizontal spacing
- Maximum platform limit
- Randomized platform positions
- Lightweight and beginner-friendly
- Easy integration into existing Unity projects

---

## Requirements

- Unity 2021 or newer
- A player object with the `Player` tag
- A platform prefab

---

## Setup Instructions

### 1. Create the Platform Prefab

1. Create a platform GameObject in your scene
2. Add:
   - Sprite Renderer / Mesh Renderer
   - Collider2D or Collider
3. Drag the object into the Project folder to create a prefab

---

### 2. Create the Player

Make sure your player GameObject:

- Has the tag:
  ```text
  Player
````

* Contains movement and physics components

---

### 3. Add the Script

1. Create an empty GameObject
2. Rename it to:

   ```text
   PlatformSpawner
   ```
3. Attach the `PlatformSpawner.cs` script

---

### 4. Assign the Platform Prefab

In the Inspector:

* Drag your platform prefab into:

  ```text
  Platform Prefab
  ```

---

## Inspector Variables

| Variable                   | Description                               |
| -------------------------- | ----------------------------------------- |
| `platformPrefab`           | The platform object to spawn              |
| `maxPlatforms`             | Total number of platforms allowed         |
| `initialPlatforms`         | Platforms spawned at the start            |
| `verticalGap`              | Distance between platforms vertically     |
| `horizontalRange`          | Random horizontal spawn range             |
| `initialPlatformYPosition` | Starting Y position of the first platform |

---

## How It Works

* The spawner creates an initial set of platforms
* As the player moves upward, new platforms generate ahead
* Platforms stop spawning once the maximum limit is reached
* The script uses randomized X positions for variety

---

## Example Use Cases

* Doodle Jump style games
* Endless vertical platformers
* Tower climbing games
* Infinite runner prototypes

---

## Future Improvements

Possible upgrades you can add:

* Multiple platform types
* Moving platforms
* Platform pooling system
* Difficulty scaling
* Coin and enemy spawning
* Finish line generation

---

## Script Preview

```csharp
void SpawnPlatform()
{
    Vector3 spawnPosition = new Vector3();
    spawnPosition.y = initialPlatformYPosition;
    spawnPosition.x = Random.Range(-horizontalRange, horizontalRange);

    Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

    initialPlatformYPosition += verticalGap;
    platformsSpawned++;
}
```

---

## License

This project is open-source and free to use for learning and personal projects.

---

## Author

Created by StixKnowledge

```
```

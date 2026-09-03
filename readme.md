# 🎮 2D Platformer — Protect the Girl

> **My first game made with Unity! 🚀**

This is a simple **2D platformer game** that I built as my first Unity project.

The main goal of this project was **learning**. Rather than trying to build a large or highly polished game, I wanted to understand the fundamentals of game development, Unity, C#, player movement, combat, enemies, collisions, animation, and game logic by actually building something playable.

> **A small project, built to learn, experiment, and improve.**

---

## 🎯 About the Game

The game is a simple 2D platformer where the player controls a main character whose objective is to **protect a little girl from incoming enemies**.

Enemies can approach from **both sides of the level**, so the player needs to move around, react to threats, and defend the girl.

```text
        👾 👾 👾
             ↓
              ↘
        🧍  👧  ←  👾 👾 👾
       Player  Girl
```

### Main Objective

**Keep the girl safe while defeating incoming enemies.**

---

## 🕹️ Gameplay

The gameplay is intentionally simple because this is primarily a learning project.

The player needs to:

1. Move around the platform.
2. Watch for enemies approaching from both sides.
3. Position the character between the enemies and the girl.
4. Attack incoming enemies.
5. Protect the girl.
6. Survive the enemy attacks.

```text
LEFT                                      RIGHT

👾 → 👾 → 👾 →       🧍 👧       ← 👾 ← 👾 ← 👾
                         ↑
                    Protect her
```

---

## 🧍 Player

The player controls the main character.

### Player abilities

* Move left and right
* Jump
* Attack enemies
* Move around the level
* Defend the girl
* React to enemies approaching from either direction

The player needs to use **movement, positioning, and timing** to protect the girl.

---

## 👧 The Girl

The girl is the main objective of the game.

She is not directly controlled by the player. Instead, the player must prevent enemies from reaching her.

A simple health system can be used to represent her safety:

```text
Girl Health

❤️ ❤️ ❤️ ❤️ ❤️

        ↓
   Enemy reaches girl

❤️ ❤️ ❤️ ❤️ 💔

        ↓
   Health reaches 0

     GAME OVER
```

---

## 👾 Enemies

Enemies can enter the level from **both directions**.

```text
LEFT SIDE                         RIGHT SIDE

👾 👾 👾  ───────→  🧍 👧  ←───────  👾 👾 👾
```

This creates a simple defensive challenge where the player must constantly pay attention to both sides.

### Possible Enemy Types

As I continue learning, I could experiment with different enemy behaviors:

| Enemy Type      | Behavior                            |
| --------------- | ----------------------------------- |
| 👾 Basic Enemy  | Moves toward the target             |
| 🏃 Fast Enemy   | Moves quickly                       |
| 🛡️ Heavy Enemy | Slower but harder to defeat         |
| 👹 Elite Enemy  | Stronger enemy with unique behavior |
| 🌊 Wave Enemy   | Appears during larger enemy waves   |

---

## ⚔️ Combat

The game includes a simple combat system.

The player can attack enemies before they reach the girl.

The combat system gives me an opportunity to learn about:

* Player attacks
* Attack animations
* Hit detection
* Colliders
* Enemy health
* Damage handling
* Attack cooldowns
* Enemy defeat
* Basic combat feedback

---

## 🎮 Controls

| Action     | Keyboard                  |
| ---------- | ------------------------- |
| Move Left  | `A` / `←`                 |
| Move Right | `D` / `→`                 |
| Jump       | `Space`                   |
| Attack     | `J` / `Left Mouse Button` |
| Pause      | `Esc`                     |

> Controls may change as the project develops.

---

## 🧠 What I Wanted to Learn

Since this is my **first Unity game**, learning was the main focus of the project.

I wanted to get hands-on experience with:

* 🎮 Unity Editor
* 💻 C# scripting
* 🧩 GameObjects & Components
* 🏃 Player movement
* 🦘 Jumping and physics
* ⚔️ Combat systems
* 👾 Enemy behavior
* 💥 Collision detection
* ❤️ Health systems
* 🌊 Enemy spawning
* 🎬 Animations
* 🎥 Camera movement
* 🖥️ UI
* 🔊 Audio
* 🗺️ Level design
* 🎯 Game state management
* 🐛 Debugging

---

## 📚 What I Learned

This project helped me understand that game development involves many different systems working together.

For example:

```text
                    GAME
                     │
          ┌──────────┼──────────┐
          │          │          │
          ▼          ▼          ▼
       PLAYER      GIRL       ENEMY
          │          │          │
          ▼          ▼          ▼
      Movement     Health     Movement
      Jumping      Safety       AI
      Combat                  Spawning
          │                     │
          └──────────┬──────────┘
                     ▼
                GAME MANAGER
                     │
             ┌───────┴────────┐
             ▼                ▼
          VICTORY          GAME OVER
```

I also learned the importance of:

* Breaking a large idea into smaller systems
* Debugging problems instead of being afraid of them
* Understanding how Unity components interact
* Organizing scripts and game objects
* Testing gameplay repeatedly
* Learning through experimentation

---

## 🛠️ Built With

* **Unity**
* **C#**
* Unity 2D Physics
* Unity Animator
* Unity UI
* Unity GameObjects
* Unity Prefabs
* Unity Colliders & Triggers

---

## 🏗️ Main Systems

The project is built around several basic gameplay systems.

### 🧍 Player System

Responsible for:

* Player input
* Movement
* Jumping
* Attacking
* Animation

### 👧 Girl / Protection System

Responsible for:

* Girl health
* Protection objective
* Detecting when enemies reach the girl

### 👾 Enemy System

Responsible for:

* Enemy spawning
* Enemy movement
* Enemy health
* Collision detection
* Damage
* Enemy defeat

### 🎮 Game Manager

Responsible for general game state such as:

* Starting the game
* Game over
* Victory conditions
* Restarting the level

---

## 📁 Suggested Project Structure

```text
Assets/
│
├── Animations/
│
├── Audio/
│
├── Materials/
│
├── Prefabs/
│   ├── Player/
│   ├── Girl/
│   └── Enemies/
│
├── Scenes/
│
├── Scripts/
│   ├── Player/
│   ├── Enemy/
│   ├── Girl/
│   ├── Combat/
│   └── Managers/
│
├── Sprites/
│
└── UI/
```

---

## 📸 Screenshots

Some screenshots from the game:

<table>
  <tr>
    <td width="50%">
      <img src="img1.png" alt="Gameplay Screenshot 1" width="100%">
    </td>
    <td width="50%">
      <img src="img2.png" alt="Gameplay Screenshot 2" width="100%">
    </td>
  </tr>
</table>

<p align="center">
  <i>Gameplay screenshots from my first Unity game.</i>
</p>



## 🎨 Why I Made This

I wanted my first project to be **small enough to understand but interesting enough to keep me motivated**.

Instead of focusing heavily on graphics or creating a huge game, I focused on learning the fundamentals of game development.

This project is more about the **learning process** than creating a perfect final product.

---

## 🚧 Project Status

**🟡 Learning Project — In Development**

This is my first Unity game and is mainly being developed as a way to practice and learn.

There are many things that can still be improved, and I plan to continue experimenting with Unity as I learn more.


## 🚀 Getting Started

### Requirements

* [Unity](https://unity.com/)
* Unity Hub
* A computer capable of running the selected Unity version

### Run the Project

1. Clone or download this repository.

```bash
git clone https://github.com/ayaandevx/simple-2d-platformer-game.git
```

2. Open **Unity Hub**.
3. Select **Add Project**.
4. Select the project folder.
5. Open the project using the appropriate Unity version.
6. Open the main scene.
7. Press **Play** ▶️.

---

## 💡 Project Philosophy

The main idea behind this project is simple:

```text
Learn
  ↓
Build
  ↓
Make Mistakes
  ↓
Debug
  ↓
Understand
  ↓
Improve
```

I'm not trying to make my first game perfect.

I'm trying to **learn how to make games**.

---

## ❤️ My First Unity Game

This project is a small but important milestone for me because it is my **first game made with Unity**.

It gave me an opportunity to move from simply learning concepts to actually building something playable.

There is still a lot for me to learn, but this is my first step into game development.

> **First game. First steps. More to learn. 🎮**

---

## 👨‍💻 About

Built as my first Unity game while learning **C# and game development**.

I'm using this project as a place to experiment, make mistakes, solve problems, and understand how games are built.

---

<p align="center">
  <strong>🎮 Learn → Build → Break → Fix → Improve</strong>
</p>

<p align="center">
  My first Unity game.
</p>

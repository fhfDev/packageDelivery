[![Branch](https://img.shields.io/badge/branch-production-cyan.svg)](https://github.com/fhfDev/packageDelivery)
![Release](https://img.shields.io/github/v/release/fhfDev/packageDelivery?label=version)
![GitHub Release Date](https://img.shields.io/github/release-date/fhfDev/packageDelivery?color=red)
![GitHub pull requests](https://img.shields.io/github/issues-pr-raw/fhfDev/packageDelivery?color=yellow)
![GitHub repo size](https://img.shields.io/github/repo-size/fhfDev/packageDelivery)
![GitHub contributors](https://img.shields.io/github/contributors/fhfDev/packageDelivery)

# About Package Delivery
Our game aims at educating about positive and negative numbers. 

The courier goes up the floors from the ground floor, which is at 0, to the upper floors and underground floors to deliver packages to customers according to the result of the math problem. The player in the character of the courier must deliver packages. Instead of the address, there is a randomly generated math problem on the package. 

For each correctly solved problem, the player receives a coin, which will use to unlock extra features that enhance the gameplay experience.

# Controls
| KEY  | ACTION |
| ------------- | ------------- |
| D / right arrow | Move right  |
| A / left arrow | Move left  |
| W / up arrow | Jump  |

# Game mechanics
- **bulletin board** - there are four papers hanging on the bulletin board, but you can't see what's on them from the main scene. When clicked on, a tooltip for solving the examples appears, with a different tooltip on each paper.
- **the HP system** is uniform, so a poorly solved example, a collision with an enemy, a poorly chosen floor in an elevator, a poorly chosen door on a floor means -1 life. There are five lives at the start of the game. After all five are exhausted, the score resets, and the player starts over. 
- **enemies (rats and ghosts)** only have top-down movement across the stage floor. They will be in two scenes: the building lobby and upstairs. Player can avoid them, i.e., walk over, under, around, or destroy them - by solving the example.

# LAB RATS

## [Play it now!](https://rloretor.github.io/rat-labs/)

2-player local game from Global Game Jam 2024. You and a friend are lab rats in a wicked experiment: dance to the beat of the music on a 5x8 dancefloor while dodging hazardous tiles.

## Gameplay
1. Both rats start on the dancefloor and pick a song from the main menu.
2. Move in time with the music. Every on-beat move adds to your combo, an off-beat press resets it.
3. Dodge the deadly tiles, which move every beat. Touching one kills you.
4. If both rats collide they are stunned and flung in random directions.
5. The match lasts 180 seconds. The last rat alive wins, or the highest combo if both survive. The board wraps around every edge.

## Controls
Both players share one keyboard.

| Player | Keys |
|--------|------|
| Player 1 | W A S D |
| Player 2 | Arrow keys |

## Requirements
- A desktop browser with WebGL and a keyboard (no controller or touch support)

## Development
- Unity 6000.3 (WebGL build target only)
- Build the web version: `Unity -batchmode -nographics -quit -projectPath . -buildTarget WebGL -executeMethod WebGLBuild.Build`, then copy `build/WebGL` into `docs/` (served by GitHub Pages from `main` `/docs`)

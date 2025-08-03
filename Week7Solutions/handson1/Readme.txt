# Hands-On 1

## Objective:
Demonstrate ES6 concepts such as:
- map()
- arrow functions
- destructuring
- array merging
- conditional rendering

## App Name:
cricketapp

## Components:

### 1. ListOfPlayers
- Uses ES6 `map()` to loop through an array of 11 players.
- Displays their `name` and `score`.
- Uses `arrow functions` to filter players with score ≤ 70.

### 2. OddPlayers & EvenPlayers
- Uses **destructuring** to extract specific players.
- Demonstrates usage of functional components.

### 3. IndianPlayers
- Merges two arrays: `T20Players` and `RanjiTrophyPlayers` using ES6 spread operator.

## Conditional Rendering:
- A `flag` variable is used in `App.js`.
  - If `flag = true` → `ListOfPlayers` is shown.
  - If `flag = false` → `OddPlayers`, `EvenPlayers`, and `IndianPlayers` are shown.

## Output:
- Displays list of players with name & score.
- Filters and shows players scoring below 70.
- Shows odd and even players separately.
- Merged Indian player list.

## Screenshot:
- `Output/FlagTrueOutput.png`
- `Output/FlagFalseOutput.png`
- `Output/vscodeStructure.png`

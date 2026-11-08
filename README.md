# CardCreator
App to create playing cards

Generates a printable PDF with RPG cards (talents, spells, items, ...) from a JSON card set definition.

## Solution structure

```
src/
  CardCreator.Core/            Class library with all logic
    Input/                     Input JSON model (CardSetDefinition, CardSize, ...)
    Templates/                 Template catalog + embedded resources
      Resources/
        card-set.schema.json   Schema of the input file root
        Fonts/                 Shared fonts (with licenses), referenced by themes
        <Game>/
          game.json            Game config incl. default_theme
          Themes/<Theme>/      theme.json, backgrounds (with bleed)
          CardTypes/<Type>/    card-type.json, card.schema.json, layout-<size>.json
    Validation/                Definition + per-card JSON Schema validation
    Layout/                    Page formats, print settings, card placement on sheets
    Rendering/                 PDFsharp rendering (fronts, mirrored backs, cut lines, text)
    Services/                  ICardCreatorService entry point
  CardCreator.ConsoleApp/      CLI
tests/
  CardCreator.Core.Tests/      NUnit tests
samples/                       Example input files
```

## Input file

```json
{
  "output_file_path": "C:\\Users\\me\\Desktop\\cards\\IM_talents.pdf",
  "output_format": "A4",
  "page_orientation": "auto",
  "game": "Imperium Maledictum",
  "theme": "Adeptus Mechanicus",
  "card_type": "Talent",
  "card_size": "63x88mm",
  "with_backs": true,
  "cards": [
    { "name": "Fighting Spirit", "requirement": "2 Advances in Melee", "description": "You can reroll **one** failed attack roll per turn." }
  ]
}
```

- `output_file_path` - exact PDF path; existing files are never overwritten, missing directories are created.
- `output_format` - page format (`A4`).
- `page_orientation` - `portrait`, `landscape` or `auto` (fits the most cards).
- `game`, `theme`, `card_type`, `card_size` - exact values supported by the embedded templates.
- `theme` - optional. If missing or not supported by the card type, the game's `Default` theme is used and the user is notified.
- `card_size` - final (trimmed) card size `WIDTHxHEIGHTmm`; width > height means landscape.
- `with_backs` - adds a mirrored back page after each front page (front 1, back 1, front 2, ...).
- `cards` - card details validated against the card type schema; text fields support Markdown (bold, italic, line breaks).

## Usage

```
CardCreator.ConsoleApp generate <json-file> [--yes]
CardCreator.ConsoleApp list
```

- `generate` - creates the PDF. Invalid cards are listed and the user is asked whether to continue with valid ones (`--yes` skips the question).
- `list` - shows supported games, themes, card types and card sizes.

## License

AGPL-3.0. Uses PDFsharp/MigraDoc under the AGPL license.
Chakra Petch font is licensed under the SIL Open Font License 1.1 (see `Templates/Resources/Fonts/ChakraPetch/OFL.txt`).
